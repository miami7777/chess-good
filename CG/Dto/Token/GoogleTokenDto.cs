namespace SSO.Api.Dto.Token;

/// <summary>
/// Dto токенов от Google.
/// </summary>
public class GoogleTokenDto
{
    /// <summary>
    /// Токен доступа для сервисов Google.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Время жизни токена в секундах.
    /// </summary>
    public long ExpiresIn { get; set; }

    /// <summary>
    /// JWT , содержащий идентификационную информацию о пользователе с цифровой подписью Google
    /// </summary>
    public string IdToken { get; set; }

    /// <summary>
    /// Области доступа, предоставляемые access_token , выражены в виде списка разделенных пробелами строк с учетом регистра.
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// Определяет тип возвращаемого токена. В настоящее время это поле всегда имеет значение Bearer.
    /// </summary>
    public string TokenType { get; set; }

    /// <summary>
    /// (по желанию)
    /// Это поле присутствует только в том случае, если для параметра access_type в запросе аутентификации было установлено значение offline.
    /// Дополнительные сведения см. в разделе Обновить токены.
    /// </summary>
    public string RefreshToken { get; set; }
}

/// <summary>
/// Dto токенов от Google для Android приложений
/// </summary>
public class GoogleAndroidTokenDto
{
    /// <summary>
    /// JWT , содержащий идентификационную информацию о пользователе с цифровой подписью Google
    /// </summary>
    public string IdToken { get; set; }

    public string AccessToken { get; set; }
}