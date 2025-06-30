namespace SSO.Api.Dto.Token;

/// <summary>
/// DTO токенов.
/// </summary>
public class TokenDto
{
    /// <summary>
    /// Токен доступа.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Токен обновления.
    /// </summary>
    public string RefreshToken { get; set; }
}