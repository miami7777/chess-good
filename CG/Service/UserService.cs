using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using CG.Services.Interfaces;
using CG.Domain;
using CG.Dto.Authorization;
using CG.Dto.Token;
using CG.HttpServices.Interfaces;
using SSO.Api.Dto.Token;
using System.Configuration;
using System.Security.Claims;
using CG.Models.Lichess;
using SkiaSharp;
using CG.Helpers;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;
using static Duende.IdentityServer.Models.IdentityResources;
using CG.Models;
using PerfsStatistics = CG.Domain.Entities.PerfsStatistics;

namespace CG.Services.Implementation;

/// <summary>
/// сервис для взаимодействия с сущностью <see cref="User"/>.
/// </summary>
public class UserService : IUserService
{    
    private readonly UserManager<ApplicationUser> _userManager;  
   
    private readonly ILocalIdentityServerHttpService _identityServerHttpService;
    private readonly ILichessUsersRepositories _lichessUsersRepositories;
    private readonly SignInManager<ApplicationUser> _signInManager;    
    private readonly DataManager _dataManager;
    private readonly IMapper _mapper;

    /// <summary>
    /// Конструктор <see cref="UserService"/>.
    /// </summary>
    public UserService(
        UserManager<ApplicationUser> userManager,        
        ILocalIdentityServerHttpService identityServerHttpService,        
        SignInManager<ApplicationUser> signInManager,
        ILichessUsersRepositories lichessUsersRepositories,
        DataManager dataManager,
        IMapper mapper)
    {
        _userManager = userManager;        
        _identityServerHttpService = identityServerHttpService;
        _lichessUsersRepositories = lichessUsersRepositories;
        _signInManager = signInManager;   
        _dataManager = dataManager;
        _mapper = mapper;        
    }

    public async Task<bool> AddLichessUser(LichessAccountDto lichessAccountDto)
    {        
        var existUser = !String.IsNullOrEmpty(lichessAccountDto.Username) ?
        await _dataManager.userRepositories.GetUserByLichessIdAsync(lichessAccountDto.Username.ToLower()) : null;
        if (existUser != null)
        {
            var existLichessUserProfile = await _lichessUsersRepositories.GetLichessUserByIdAsync(lichessAccountDto.Id);            
            if (existLichessUserProfile != null)
            {
                existLichessUserProfile.Username = lichessAccountDto.Username;
                existLichessUserProfile.Title = lichessAccountDto.Title;
                existLichessUserProfile.Profile.Realname = lichessAccountDto?.Profile?.Realname;
                existLichessUserProfile.Profile.Location = lichessAccountDto?.Profile?.Location;
                var blitz = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Blitz);
                blitz.Id = existLichessUserProfile.Perfs.Blitz.Id;
                var bullet = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Bullet);
                bullet.Id = existLichessUserProfile.Perfs.Bullet.Id;
                var rapid = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Rapid);
                rapid.Id = existLichessUserProfile.Perfs.Rapid.Id;
                var classical = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Classical);
                classical.Id = existLichessUserProfile.Perfs.Classical.Id;

                existLichessUserProfile.Perfs.Blitz.Rating = blitz.Rating;                
                existLichessUserProfile.Perfs.Bullet.Rating = bullet.Rating;
                existLichessUserProfile.Perfs.Rapid.Rating = rapid.Rating;
                existLichessUserProfile.Perfs.Classical.Rating = classical.Rating;
                
                await _lichessUsersRepositories.UpdateUserAsync(existLichessUserProfile);
            }           
           
            await _signInManager.SignInAsync(existUser, false);
        }
        else
        {
            var existlichessUser = await _dataManager.lichessUsersRepositories.GetLichessUserByIdAsync(lichessAccountDto.Username.ToLower());
            if (existlichessUser == null)
            {
                var lichessUserProfile = new ProfileLichess
                {
                    Id = 0,
                    Realname = lichessAccountDto?.Profile?.Realname,
                    Location = lichessAccountDto?.Profile?.Location,
                    Fiderating = lichessAccountDto?.Profile?.Fiderating
                };
                var blitz = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Blitz);
                var rapid = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Rapid);
                var bullet = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Bullet);
                var classical = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Classical);
                var lichessUserPerfs = new PerfsLichess
                {
                    Id = 0,
                    Blitz = blitz,
                    Rapid = rapid,
                    Bullet = bullet,
                    Classical = classical
                };

                var lichessUser = new LichessUsers
                {
                    Id = lichessAccountDto.Id,
                    createdat = lichessAccountDto.createdat,
                    Title = lichessAccountDto.Title,
                    Username = lichessAccountDto.Username,
                    seenat = lichessAccountDto.seenat,
                    Profile = lichessUserProfile,
                    Perfs = lichessUserPerfs

                };

                await _dataManager.lichessUsersRepositories.SaveUserAsync(lichessUser);
            }
                var newUser = new ApplicationUser
                {
                    Id = UserHelper.GenString(5),
                    UserName = lichessAccountDto.Username,
                    ProfileLichess = lichessAccountDto.Username,
                    LichessUserId = lichessAccountDto.Username,
                    Email = $"{lichessAccountDto.Username}@{lichessAccountDto.Username}.ru",
                    EmailConfirmed = false,
                    NormalizedUserName = lichessAccountDto.Username?.Normalize(),
                };
                string password = Guid.NewGuid().ToString().ToLower().Substring(0, 10);
                var userCreationResult = _userManager.CreateAsync(newUser, password);
                userCreationResult.Wait();
                if (userCreationResult.Result.Succeeded)
                {
                    Task<IdentityResult> newUserRole = _userManager.AddToRoleAsync(newUser, "user");
                    newUserRole.Wait();
                }
                else
                    throw new Exception();



                var addUser = await _dataManager.userRepositories.GetUserByLichessIdAsync(lichessAccountDto.Username.ToLower());
                if (addUser != null)
                {
                    await _signInManager.SignInAsync(addUser, false);
                }            
        }

        return true;
    }
    public async Task<bool> LinkLichessUser(LichessAccountDto lichessAccountDto, string profileId)
    {
        var existUser = !String.IsNullOrEmpty(lichessAccountDto.Username) ?
        await _dataManager.userRepositories.GetUserByLichessIdAsync(lichessAccountDto.Username.ToLower()) : null;
        if (existUser == null)
        {
            var existUserProfile = await _userManager.FindByNameAsync(profileId);
            var existlichessUser = await _dataManager.lichessUsersRepositories.GetLichessUserByIdAsync(lichessAccountDto.Username.ToLower());

            if (existUserProfile != null && existlichessUser == null)
            {
                var lichessUserProfile = new ProfileLichess
                {
                    Id = 0,
                    Realname = lichessAccountDto?.Profile?.Realname,
                    Location = lichessAccountDto?.Profile?.Location,
                    Fiderating = lichessAccountDto?.Profile?.Fiderating
                };
                var blitz = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Blitz);
                var rapid = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Rapid);
                var bullet = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Bullet);
                var classical = _mapper.Map<PerfsStatisticsLichess>(lichessAccountDto?.Perfs?.Classical);
                var lichessUserPerfs = new PerfsLichess
                {
                    Id = 0,
                    Blitz = blitz,
                    Rapid = rapid,
                    Bullet = bullet,
                    Classical = classical
                };

                var lichessUser = new LichessUsers
                {
                    Id = lichessAccountDto.Id,
                    createdat = lichessAccountDto.createdat,
                    Title = lichessAccountDto.Title,
                    Username = lichessAccountDto.Username,
                    seenat = lichessAccountDto.seenat,
                    Profile = lichessUserProfile,
                    Perfs = lichessUserPerfs
                };
                await _dataManager.lichessUsersRepositories.SaveUserAsync(lichessUser);
                existUserProfile.ProfileLichess = lichessAccountDto.Username;
                existUserProfile.LichessUserId = lichessAccountDto.Username;
                await _userManager.UpdateAsync(existUserProfile);
            }
            else if (existUserProfile != null)
            {
                existUserProfile.ProfileLichess = lichessAccountDto.Username;
                existUserProfile.LichessUserId = lichessAccountDto.Username;
                await _userManager.UpdateAsync(existUserProfile);
            }        
        }
        else
            return false;

        return true;
    }
    public async Task UpdateLichessUser(LichessAccountDto user)
    {       
       
        var existLichessUserProfile = await _lichessUsersRepositories.GetLichessUserByIdAsync(user.Id);
        if (existLichessUserProfile != null)
        {
            existLichessUserProfile.Username = user.Username;
            existLichessUserProfile.Title = user.Title;
            existLichessUserProfile.Profile.Realname = user?.Profile?.Realname;
            existLichessUserProfile.Profile.Location = user?.Profile?.Location;
            var blitz = _mapper.Map<PerfsStatisticsLichess>(user?.Perfs?.Blitz);
            blitz.Id = existLichessUserProfile.Perfs.Blitz.Id;
            var bullet = _mapper.Map<PerfsStatisticsLichess>(user?.Perfs?.Bullet);
            bullet.Id = existLichessUserProfile.Perfs.Bullet.Id;
            var rapid = _mapper.Map<PerfsStatisticsLichess>(user?.Perfs?.Rapid);
            rapid.Id = existLichessUserProfile.Perfs.Rapid.Id;
            var classical = _mapper.Map<PerfsStatisticsLichess>(user?.Perfs?.Classical);
            classical.Id = existLichessUserProfile.Perfs.Classical.Id;

            existLichessUserProfile.Perfs.Blitz.Rating = blitz.Rating;
            existLichessUserProfile.Perfs.Bullet.Rating = bullet.Rating;
            existLichessUserProfile.Perfs.Rapid.Rating = rapid.Rating;
            existLichessUserProfile.Perfs.Classical.Rating = classical.Rating;           

            await _lichessUsersRepositories.UpdateUserAsync(existLichessUserProfile);
        }
        
        
    }
    public JwtSecurityToken GetUserDataToken(string token)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RemoveLinkLichessUser(string profileId)
    {
        
            var existUserProfile = await _userManager.FindByNameAsync(profileId);
            if (existUserProfile != null)
            {                
                existUserProfile.ProfileLichess = null;
                existUserProfile.LichessUserId = null;
                await _userManager.UpdateAsync(existUserProfile);
            }        

        return true;
    }

    public async Task UpdateRoleUser(ApplicationUser user, string roleId)
    {
        var roles = await _userManager.GetRolesAsync(user);
        if (roles != null)
        {
            await _userManager.RemoveFromRolesAsync(user,roles);
            await _userManager.AddToRoleAsync(user, roleId);
        }
    }

    public async Task<bool> AddUserData(ApplicationUser user)
    {
        await _dataManager.userRepositories.CreateUserPerfsAsync(user);
        return true;             
    }
    public async Task<bool> AddUserData(ApplicationUser user, LichessAccountDto lichessAccountDto)
    {
        await _dataManager.userRepositories.CreateUserPerfsAsync(user,lichessAccountDto);
        return true;
    }

    public async Task UpdateUserData(ApplicationUser user)
    {
        await _dataManager.userRepositories.SaveUserAsync(user);
    }

    public ApplicationUser GetUserByName(string username)
    {
        return _dataManager.userRepositories.GetUserByNameAsync(username).Result;
    }
    public async Task<ApplicationUser> GetUserRatingAsync(string username)
    {
        var user = await _dataManager.userRepositories.GetUserRatingAsync(username);
        
        return user;
    }    
}