using Duende.IdentityModel.Client;

namespace CG.HttpServices.Interfaces;

/// <summary>
/// Интерфейс взаимодействия с локальным IdentityServer.
/// </summary>
public interface ILocalIdentityServerHttpService
{
    /// <summary>
    /// Получить токен.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Ответ с токеном.</returns>
    Task<TokenResponse> GetTokenAsync(TokenRequest request);

    /// <summary>
    /// Получить токен 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="guestName">Имя гостя, для гостевой авторизации.</param>
    /// <returns>Ответ с токеном.</returns>
    Task<TokenResponse> GetTokenByPasswordAsync(PasswordTokenRequest request, Dictionary<string, string>? guestName = null);

    /// <summary>
    /// Получить токен.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Ответ с токеном.</returns>
    Task<TokenResponse> GetTokenByAuthCodeAsync(AuthorizationCodeTokenRequest request);

    /// <summary>
    /// Отозвать токен.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Ответ на отзыв токена</returns>
    Task<TokenRevocationResponse> RevokeTokenAsync(TokenRevocationRequest request);

    /// <summary>
    /// Обновить токен.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Ответ с токеном.</returns>
    Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request, string access_token);
}