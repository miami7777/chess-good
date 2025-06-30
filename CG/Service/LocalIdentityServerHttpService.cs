using Duende.IdentityServer.Models;
using CG.Helpers;
using CG.HttpServices.Interfaces;
using System.Net.Http.Headers;
using static SSO.Api.Extensions.UriExtensions;
using Duende.IdentityModel.Client;

namespace CG.HttpServices.Implementation;

/// <summary>
/// Http-сервис для взаимодействия с локальным IdentityServer.
/// </summary>
public class LocalIdentityServerHttpService : ILocalIdentityServerHttpService
{
    private readonly HttpClient _client;

    /// <summary>
    /// Конструктор <see cref="LocalIdentityServerHttpService"/>.
    /// </summary>
    /// <param name="httpContextAccessor"></param>
    public LocalIdentityServerHttpService(IHttpContextAccessor httpContextAccessor)
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri(UriHelper.GetBaseUri(httpContextAccessor));
    }

    /// <inheritdoc />
    public async Task<TokenResponse> GetTokenAsync(TokenRequest request)
    {
        request.RequestUri = new Uri(_client.BaseAddress!, "connect/token");
        request.Method = HttpMethod.Post;
        return await _client.RequestTokenAsync(request);
    }

    /// <inheritdoc />
    public async Task<TokenResponse> GetTokenByPasswordAsync(PasswordTokenRequest request,
        Dictionary<string, string>? listClaims = null)
    {
        var uri = new Uri(_client.BaseAddress!, "connect/token");
        if (listClaims != null)
        {
            foreach (var claimParameter in listClaims)
            {
                AddQueryParameter(ref uri, claimParameter.Key, claimParameter.Value);
            }
        }

        request.RequestUri = uri;
        request.GrantType = GrantType.ResourceOwnerPassword;
        request.Method = HttpMethod.Post;
        return await _client.RequestPasswordTokenAsync(request);
    }

    /// <inheritdoc />
    public async Task<TokenResponse> GetTokenByAuthCodeAsync(AuthorizationCodeTokenRequest request)
    {
        request.RequestUri = new Uri(_client.BaseAddress!, "connect/token");
        request.GrantType = GrantType.AuthorizationCode;
        request.Method = HttpMethod.Post;
        return await _client.RequestAuthorizationCodeTokenAsync(request);
    }

    /// <inheritdoc />
    public async Task<TokenRevocationResponse> RevokeTokenAsync(TokenRevocationRequest request)
    {
        request.RequestUri = new Uri(_client.BaseAddress!, "connect/revocation");
        request.Method = HttpMethod.Post;
        return await _client.RevokeTokenAsync(request);
    }

    /// <inheritdoc />
    public async Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request, string accessToken)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        request.RequestUri = new Uri(_client.BaseAddress!, "connect/token");
        request.GrantType = "refresh_token";
        request.Method = HttpMethod.Post;
        return await _client.RequestRefreshTokenAsync(request);
    }

    public Task<TokenResponse> AddClaimToAccessToken(Uri uri, string claimValue)
    {
        throw new NotImplementedException();
    }
}