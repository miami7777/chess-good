using CG.Domain;
using CG.Domain.Entities;
using CG.Dto.ResponseMessage;
using CG.Models;
using CG.Models.Enum;
using CG.Models.Lichess;
using CG.Service.Interfaces;
using CG.Services.Implementation;
using CG.Services.Interfaces;
using static Duende.IdentityServer.IdentityServerConstants;

namespace CG.Service
{
    public class CalculationRatingService : ICalculationRatingService
    {
        private readonly IUserService _userService;
        private IHttpContextAccessor _httpContextAccessor;

        public CalculationRatingService(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ApplicationUser> CalculateRatingAsync(GameState game) 
        {
            if (_httpContextAccessor != null)
            {
                var currentUser = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
                if (currentUser != null)
                {
                    var user = await _userService.GetUserRatingAsync(currentUser);
                    if (user != null)
                    {
                        var perfsStatistics = GetPerfsStatistics(game,user);
                        var rating = GetRatingGame(game,user);
                        perfsStatistics.Rating += rating;
                        perfsStatistics.Games++;
                        SavePerfsStatistics(game.Options.type, user, perfsStatistics);
                        await _userService.UpdateUserData(user);
                    } 
                    return user;
                }               
            }
            return null;
        }
        public Domain.Entities.PerfsStatistics GetPerfsStatistics(GameState game,ApplicationUser user)
        {
            return GetRatingByType(game.Options.type, user);                       
        }
        public Domain.Entities.PerfsStatistics GetRatingByType(Type_Game type, ApplicationUser user)
        {
            if (type == Models.Enum.Type_Game.Bullet)
            {
                return user.Perfs.Bullet ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.Blitz)
            {
                return user.Perfs.Blitz ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.Rapid)
            {
                return user.Perfs.Rapid ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.Classical)
            {
                return user.Perfs.Classical ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.BulletInc)
            {
                return user.Perfs.BulletInc ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.BlitzInc)
            {
                return user.Perfs.BlitzInc ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.RapidInc)
            {
                return user.Perfs.RapidInc ?? new Domain.Entities.PerfsStatistics();
            }
            if (type == Models.Enum.Type_Game.ClassicalInc)
            {
                return user.Perfs.ClassicalInc ?? new Domain.Entities.PerfsStatistics();
            }
            return user.Perfs.Blitz ?? new Domain.Entities.PerfsStatistics();
        }
            public void SavePerfsStatistics(Type_Game type_Game, ApplicationUser user, Domain.Entities.PerfsStatistics perfsStatistics)
        {
            if (type_Game == Models.Enum.Type_Game.Bullet)
            {
                user.Perfs.Bullet = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.Blitz)
            {
                user.Perfs.Blitz = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.Rapid)
            {
                user.Perfs.Rapid = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.Classical)
            {
                user.Perfs.Classical = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.BulletInc)
            {
                user.Perfs.BulletInc = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.BlitzInc)
            {
                user.Perfs.BlitzInc = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.RapidInc)
            {
                user.Perfs.RapidInc = perfsStatistics;
            }
            if (type_Game == Models.Enum.Type_Game.ClassicalInc)
            {
                user.Perfs.ClassicalInc = perfsStatistics;
            }            
        }
        public int GetRatingGame(GameState game,ApplicationUser user)
        {
            int rating;
            
                    if ((game.Result == "1-0" && game.Players[0].UserName == user.UserName)
                            || (user != null && game.Result == "0-1" && game.Players[1].UserName == user.UserName))
                        { 
                            rating = 5;
                        }
                    else if ((user != null && game.Result == "1-0" && game.Players[1].UserName == user.UserName) 
                            || (user != null && game.Result == "0-1" && game.Players[0].UserName == user.UserName))
                        {
                            rating = -5;
                        }                   
                    else if (user != null && game.Result == "1/2-1/2" && game.Players[0].UserName == user.UserName)
                        {
                            rating = -1;
                        }
                    else
                        {
                            rating = 1;
                        }
            return rating;                
        }

        public async Task<int> GetRatingAsync(GameState game)
        {
            if (_httpContextAccessor != null)
            {
                var currentUser = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
                if (currentUser != null)
                {
                    var user = await _userService.GetUserRatingAsync(currentUser);
                    if (user != null)
                    {
                        var perfsStatistics = GetPerfsStatistics(game, user);                        
                        return perfsStatistics.Rating;                        
                    }                    
                }
            }
            return 1500;
        }
       
        public async Task<int> GetRatingByTypeAsync(Type_Game type)
        {
            if (_httpContextAccessor != null)
            {
                var currentUser = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
                if (currentUser != null)
                {
                    var user = await _userService.GetUserRatingAsync(currentUser);
                    if (user != null)
                    {
                        var perfsStatistics = GetRatingByType(type,user);
                        return perfsStatistics.Rating;
                    }
                }
            }
            return 1500;
        }

        public async Task<int> GetRatingByTypeAndUserAsync(Type_Game type, string username)
        {        
            var user = await _userService.GetUserRatingAsync(username);
            if (user != null)
            {
                var perfsStatistics = GetRatingByType(type, user);
                return perfsStatistics.Rating;
            }            
            return 1500;
        }

        public (string, string) GetAvatarAsync(List<Player> gamePlayers)
        {
            var avatar1 = _userService.GetUserByName(gamePlayers[0].UserName)?.Avatar ?? "default.jpg";
            var avatar2 = _userService.GetUserByName(gamePlayers[1].UserName)?.Avatar ?? "default.jpg";           
            
            return (avatar1, avatar2);
        }
    }
}
