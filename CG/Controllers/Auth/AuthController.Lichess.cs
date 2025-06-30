using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using SSO.Api.Dto.ResponseMessage;
using SSO.Api.Dto.Token;
using System.Text.RegularExpressions;
using System.Text;
using CG.Helpers;
using CG.Dto.Authorization;
using static Microsoft.AspNetCore.Http.StatusCodes;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Cryptography;
using CG.Dto.Token;
using Org.BouncyCastle.Asn1.Cmp;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Duende.IdentityModel;
using Microsoft.AspNetCore.Identity;


namespace CG.Controllers.Auth;

/// <inheritdoc />
public partial class AuthController
{
    [AllowAnonymous]
    [HttpGet("login/lichess")]
    public async Task<IActionResult> LoginLichess(
        [FromQuery] string? redirectUri, [FromQuery] string prefix = "")
    {
        var state = Guid.NewGuid().ToString().ToSha256();       
        var code_verifier = GenerateCodeVerifier(GenerateToken());
        var scopes = new[]
        {           
            "email:read",
            "preference:read",
            "preference:write"                                
        };

        var uri = _lichessIdentityServerHttpService.GetAuthorizationCodeUri(
            state: state,
            redirectUri: redirectUri,            
            code_verifier: code_verifier,
            scope: string.Join(" ", scopes),
            prefix:prefix);        
        await _stateKeyCache.UpsertLichessStateKey(code_verifier, state);

        return Redirect(uri.ToString());
    }
    [HttpGet("authorize")]
    public async Task<ActionResult<ResponseMessage<UserAuthDto>>> GetLichessAccessToken(
        [FromQuery] string state,
        [FromQuery] string code        
        )
    {
        if (!await _stateKeyCache.CheckLichessStateKey(state))
            return _responseBuilder.Build(Status401Unauthorized);
        var code_verifier = _stateKeyCache.GetCodeVerifier(state);
        var result = await _lichessIdentityServerHttpService.GetAccessToken(code,code_verifier, "");
        if (result.IsSuccessStatusCode)
        {            
            var body = await HttpHelper.ParseHttpJsonResponseMessage<LichessTokenDto>(result,
                new SnakeCaseNamingStrategy());
            if (body != null)
            {
                var userLichess = await _lichessIdentityServerHttpService.GetLichessAccountData(body.access_token);                              
                var addLichessUser = _userService.AddLichessUser(userLichess).Result;
                if (addLichessUser)
                {
                    var user = await _userManager.FindByNameAsync(userLichess.Username);
                    if (user != null && user.PerfsId == null)
                    {
                        await _userService.AddUserData(user, userLichess);
                    }
                    HttpContext.Response.Cookies.Append("lichess_access_token", body.access_token, new CookieOptions { HttpOnly = true, Secure = true });
                    return Redirect("/");
                }
                else
                    return _responseBuilder.SetDescription("ErrorWhileUserCreation")
                        .Build(Status400BadRequest);
            }            
        }

        return _responseBuilder.SetDescription("Пользователь не найден!").Build(Status404NotFound);        
    }

    [Authorize]
    [HttpGet("link/lichess")]
    public async Task<IActionResult> LinkLichessAccessToken(
        [FromQuery] string? redirectUri, [FromQuery] string prefix = ""
        )
    {
        var state = Guid.NewGuid().ToString().ToSha256();
        var code_verifier = GenerateCodeVerifier(GenerateToken());
        var scopes = new[]
        {
            "email:read",
            "preference:read",
            "preference:write"
        };

        var uri = _lichessIdentityServerHttpService.GetAuthorizationCodeUri(
            state: state,
            redirectUri: redirectUri,
            code_verifier: code_verifier,
            scope: string.Join(" ", scopes),
            prefix: prefix);
        await _stateKeyCache.UpsertLichessStateKey(code_verifier, state);

        return Redirect(uri.ToString());
    }
    [Authorize]
    [HttpGet("auth/GetOrgTournament")]
    public async Task<IActionResult> GetOrgTournament()
    {
        var state = Guid.NewGuid().ToString().ToSha256();
        var code_verifier = GenerateCodeVerifier(GenerateToken());
        var scopes = new[]
        {
            "email:read",
            "preference:read",
            "preference:write",
            "challenge:bulk"
        };

        var uri = _lichessIdentityServerHttpService.GetAuthorizationCodeUri(
            state: state,
            redirectUri: "",
            code_verifier: code_verifier,
            scope: string.Join(" ", scopes),
            prefix: "_trainer");
        await _stateKeyCache.UpsertLichessStateKey(code_verifier, state);

        return Redirect(uri.ToString());
    }
    [Authorize]
    [HttpGet("remove/link/lichess")]
    public async Task<IActionResult> RemoveLinkLichess()
    {
        var removelinkLichessUser = await _userService.RemoveLinkLichessUser(User.Identity.Name);
        if (removelinkLichessUser)
        {
            HttpContext.Response.Cookies.Delete("lichess_access_token");
            return RedirectToAction("Profile", "Home", new { area = "adm" });
        }
        else
            return _responseBuilder.SetDescription("ErrorWhileRemoveLinkLichess")
                .Build(Status400BadRequest);
    }
    [Authorize]
    [HttpGet("authorize_user")]
    public async Task<ActionResult<ResponseMessage<UserAuthDto>>> AuthorizeLichessAccessToken(
        [FromQuery] string state,
        [FromQuery] string code        
        )
    {
        if (!await _stateKeyCache.CheckLichessStateKey(state))
            return _responseBuilder.Build(Status401Unauthorized);
        var code_verifier = _stateKeyCache.GetCodeVerifier(state);
        var result = await _lichessIdentityServerHttpService.GetAccessToken(code, code_verifier,"_user");
        if (result.IsSuccessStatusCode)
        {
            var body = await HttpHelper.ParseHttpJsonResponseMessage<LichessTokenDto>(result,
                new SnakeCaseNamingStrategy());
            if (body != null)
            {
                var userLichess = await _lichessIdentityServerHttpService.GetLichessAccountData(body.access_token);
                var linkLichessUser = _userService.LinkLichessUser(userLichess,User.Identity.Name).Result;
                if (linkLichessUser)
                {
                    HttpContext.Response.Cookies.Append("lichess_access_token", body.access_token, new CookieOptions { HttpOnly = true, Secure = true });
                    return RedirectToAction("Profile","Home", new {area="adm"});
                }
                else
                    return _responseBuilder.SetDescription("ErrorWhileUserCreation")
                        .Build(Status400BadRequest);
            }
        }

        return _responseBuilder.SetDescription("Пользователь не найден!").Build(Status404NotFound);
    }
    [Authorize]
    [HttpGet("authorize_trainer")]
    public async Task<ActionResult<ResponseMessage<UserAuthDto>>> LinkOrgAccessToken(
        [FromQuery] string state,
        [FromQuery] string code
        )
    {
        if (!await _stateKeyCache.CheckLichessStateKey(state))
            return _responseBuilder.Build(Status401Unauthorized);
        var code_verifier = _stateKeyCache.GetCodeVerifier(state);
        var result = await _lichessIdentityServerHttpService.GetAccessToken(code, code_verifier, "_trainer");
        if (result.IsSuccessStatusCode)
        {
            var body = await HttpHelper.ParseHttpJsonResponseMessage<LichessTokenDto>(result,
                new SnakeCaseNamingStrategy());
            if (body != null)
            {
                var userLichess = await _lichessIdentityServerHttpService.GetLichessAccountData(body.access_token);
                var addLichessUser = _userService.AddLichessUser(userLichess).Result;
                if (addLichessUser)
                {
                    HttpContext.Response.Cookies.Append("lichess_access_token", body.access_token, new CookieOptions { HttpOnly = true, Secure = true });
                    return RedirectToAction("Profile", "Home", new { area = "adm" });
                }
                else
                    return _responseBuilder.SetDescription("ErrorWhileUserCreation")
                        .Build(Status400BadRequest);
            }
        }

        return _responseBuilder.SetDescription("Пользователь не найден!").Build(Status404NotFound);
    }
    private static string GenerateNonce()
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz123456789";
        var random = new Random();
        var nonce = new char[43];
        for (int i = 0; i < nonce.Length; i++)
        {
            nonce[i] = chars[random.Next(chars.Length)];
        }
        
        return new string(nonce);
    }
    private const int BYTE_LENGTH = 32;

    /// <summary>
    /// Generate a fixed length token that can be used in url without endcoding it
    /// </summary>
    /// <returns></returns>
    public static string GenerateToken()
    {
        // get secure array bytes
        byte[] secureArray = GenerateRandomBytes();

        // convert in an url safe string
        string urlToken = WebEncoders.Base64UrlEncode(secureArray);

        return urlToken;
    }

    /// <summary>
    /// Generate a cryptographically secure array of bytes with a fixed length
    /// </summary>
    /// <returns></returns>
    private static byte[] GenerateRandomBytes()
    {
        using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
        {
            byte[] byteArray = new byte[BYTE_LENGTH];
            provider.GetBytes(byteArray);

            return byteArray;
        }
    }
    private static string GenerateCodeVerifier(string codeVerifier)
    {       
        var hash = Encoding.UTF8.GetBytes(codeVerifier);
        var b64Hash = Convert.ToBase64String(hash);
        var code = Regex.Replace(b64Hash, "\\+", "-");
        code = Regex.Replace(code, "\\/", "_");
        code = Regex.Replace(code, "=+$", "");
        return code;
    }
}