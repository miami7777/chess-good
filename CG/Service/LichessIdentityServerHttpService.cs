using Duende.IdentityServer.Models;
using Newtonsoft.Json.Serialization;
using SSO.Api.Dto.Token;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CG.Helpers;
using CG.Interfaces;
using CG.Models.Lichess;
using CG.HttpServices.Interfaces;
using static SSO.Api.Extensions.UriExtensions;

namespace CG.HttpServices.Implementation;

/// <summary>
/// Http-сервис для взаимодействия с Google поставщиком OpenId.
/// </summary>
public class LichessIdentityServerHttpService : ILichessIdentityServerHttpService
{   
    private readonly IHttpClientFactory _clientFactory;
    private readonly IHttpHelper _httpHelper;

    /// <summary>
    /// Конструктор <see cref="LichessIdentityServerHttpService"/>.
    /// </summary>
    /// <param name="googleOpenIdMetadataOptions"></param>
    /// <param name="clientFactory"></param>
    public LichessIdentityServerHttpService(        
        IHttpClientFactory clientFactory,
        IHttpHelper httpHelper)
    {
        _clientFactory = clientFactory;
        _httpHelper = httpHelper;
    }

    public async Task<HttpResponseMessage> GetAccessToken(string code, string code_verifier, string prefix)
    {
        
        if (string.IsNullOrEmpty(code))
            throw new NullReferenceException("Code was null or empty.");
                
        var body = new List<KeyValuePair<string, string>>
        {
            new("client_id", "chess-good"),
            new("grant_type", GrantType.AuthorizationCode),
            new("code", code),
            new("code_verifier", code_verifier),            
            new("redirect_uri","https://chess-good.ru/test"),
            
        };
        var redUri = $"https://chess-good.ru/authorize{prefix}";
        var par = "{" + $"\"client_id\":\"chess-good\",\"grant_type\":\"{GrantType.AuthorizationCode}\",\"code\":\"{code}\",\"code_verifier\":\"{code_verifier}\",\"redirect_uri\":\"{redUri}\"" + "}";
               
       
        var response = await _httpHelper.SendPostAuthAsync($"/api/token",par);
        
        
        return response;
    }

    /// <inheritdoc />
    public Uri GetAuthorizationCodeUri(string state,string code_verifier, string? redirectUri, string scope,string prefix)
    {
        string code_chalendge = GenerateCodeChallenge(code_verifier);
        var uri = new Uri("https://lichess.org/oauth");
        var redUri = $"https://chess-good.ru/authorize{prefix}";
        var parameters = new Dictionary<string, string>
        {
            { "response_type", "code" },
            { "state", state },            
            { "client_id", "chess-good" },
            { "code_challenge_method", "S256" },
            { "code_challenge", code_chalendge},
            {
                "redirect_uri",
                string.IsNullOrEmpty(redirectUri) ? redUri : redirectUri
            },
            { "scope", scope }            
        };
        AddQueryParameters(ref uri, parameters);
        return uri;
    }    
    private static string GenerateCodeChallenge(string codeVerifier)
    {
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
        var b64Hash = Convert.ToBase64String(hash);
        var code = Regex.Replace(b64Hash, "\\+", "-");
        code = Regex.Replace(code, "\\/", "_");
        code = Regex.Replace(code, "=+$", "");
        return code;
    }

    public async Task<LichessAccountDto> GetLichessAccountData(string token)
    {
        if (string.IsNullOrEmpty(token))
            throw new NullReferenceException("Code was null or empty.");

        
        var response = await _httpHelper.SendGetAsync($"/api/account",token);
        var profile = await HttpHelper.ParseHttpJsonResponseMessage<LichessAccountDto>(response,
                new SnakeCaseNamingStrategy());        
        return profile;
    }
}