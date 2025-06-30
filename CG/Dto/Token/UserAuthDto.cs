using SSO.Api.Dto.Token;
using CG.Models;

namespace CG.Dto.Authorization;

/// <summary>
/// DTO авторизации пользователя.
/// </summary>
public class UserAuthDto
{
    /// <summary>
    /// Токены.
    /// </summary>
    public TokenDto Tokens { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public UserViewModel User { get; set; }
}