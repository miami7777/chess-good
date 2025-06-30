using System.IdentityModel.Tokens.Jwt;
using CG.Domain.Entities;
using CG.Dto.Token;
using CG.Models.Lichess;
using CG.Domain;
using CG.Dto.Authorization;
using CG.Models;


namespace CG.Services.Interfaces;

/// <summary>
/// Интерфейс взаимодействия с сущностью <see cref="ApplicationUser"/>.
/// </summary>
public interface IUserService
{
    public ApplicationUser GetUserByName(string username);
    public Task<ApplicationUser> GetUserRatingAsync(string username);
    public Task<bool> AddLichessUser(LichessAccountDto lichessAuthDto);
    public Task<bool> AddUserData(ApplicationUser user);
    public Task<bool> AddUserData(ApplicationUser user,LichessAccountDto lichessAccountDto);
    public Task<bool> LinkLichessUser(LichessAccountDto lichessAuthDto,string profileId);
    public Task<bool> RemoveLinkLichessUser(string profileId);
    public Task UpdateLichessUser(LichessAccountDto user);
    public Task UpdateUserData(ApplicationUser user);
    public Task UpdateRoleUser(ApplicationUser user, string roleId);

    /// <summary>
    /// Получить данные с токена
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public JwtSecurityToken GetUserDataToken(string token);

    
}