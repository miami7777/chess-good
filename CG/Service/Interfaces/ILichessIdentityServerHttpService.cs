
using CG.Models.Lichess;

namespace CG.HttpServices.Interfaces;

/// <summary>
/// Интерфейс взаимодействия с Google поставщиком OpenId.
/// </summary>
public interface ILichessIdentityServerHttpService
{
    /// <summary>
    /// Получить код авторизации.
    /// </summary>
    /// <param name="state">ключ сессии.</param>
    /// <param name="redirectUri">URI-адрес перенаправления.</param>
    /// <param name="scope">области.</param>
    /// <returns>URI-адрес.</returns>
    public Uri GetAuthorizationCodeUri(string state, string code_verifier, string? redirectUri, string scope,string prefix);    
    public Task<HttpResponseMessage> GetAccessToken(string code,string code_verifier, string prefix);
    public Task<LichessAccountDto> GetLichessAccountData(string token);
}