namespace SSO.Api.Dto.Token;

/// <summary>
/// DTO гостевого токена.
/// </summary>
public class GuestTokenDto
{
    /// <summary>
    /// Токен доступа.
    /// </summary>
    public string AccessToken { get; set; }
}