namespace SSO.Api.Dto.Token;

/// <summary>
/// Dto токенов от Google.
/// </summary>
public class VKTokenDto
{
    /// <summary>
    /// Токен доступа для сервисов VK.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Время жизни токена в секундах.
    /// </summary>
    public long ExpiresIn { get; set; }

    /// <summary>
    /// id user vk
    /// </summary>
    public string UserId { get; set; }
}

public class VKDataDto
{
    public List<VKUserDto> Response { get; set; }
}

public class VKUserDto
{
    public int Id { get; set; }
    public string NickName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Photo_100 { get; set; }
    public string Email { get; set; }
}