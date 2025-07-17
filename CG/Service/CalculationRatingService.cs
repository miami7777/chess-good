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
                        RG rg = GetRatingGame(game,user);                        
                        perfsStatistics.Rating = rg.Rating;
                        perfsStatistics.RD = rg.RD;
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
        public int GetKfByType(Domain.Entities.PerfsStatistics type, ApplicationUser user)
        {
            //int kf = 10;
            //if (type.Games <= 10 && type.Rating < 2400)
            //{
            //    kf = 40;
            //}
            //if (type.Games <= 20 && type.Rating < 2300)
            //{
            //    kf = 30;
            //}
            //if (type.Games <= 30 && type.Rating < 2200)
            //{
            //    kf = 20;
            //}

            return type.RD;
        }
        public RG GetRatingGame(GameState game,ApplicationUser user)
        {            
            return GetNewEloRating(game,user);                
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

        public (int, int,string,string) GetAvatarAndFlagAsync(List<Player> gamePlayers)
        {
            var avatar1 = _userService.GetUserByName(gamePlayers[0].UserName)?.AvatarFilesId;
            var avatar2 = _userService.GetUserByName(gamePlayers[1].UserName)?.AvatarFilesId;
            var flag1 = _userService.GetUserByName(gamePlayers[0].UserName)?.Country ?? "ru";
            var flag2 = _userService.GetUserByName(gamePlayers[1].UserName)?.Country ?? "ru";
            return (avatar1 ?? 0, avatar2 ?? 0,flag1,flag2);
        }
        public RG GetNewEloRating(GameState game, ApplicationUser user)
        {
            int newRating;
            int newRD;
            double res = 0.5;
            double q = Math.Log(10) / 400;
            
            
              if (game.Result == "1-0" && user.UserName == game.Colors["white"].UserName)
                    res = 1;
                else if (game.Result == "0-1" && user.UserName == game.Colors["black"].UserName)
                    res = 1;
                else if (game.Result == "1-0" && user.UserName == game.Colors["black"].UserName)
                    res = 0;
                else if (game.Result == "0-1" && user.UserName == game.Colors["white"].UserName)
                    res = 0;
            int RD = user.UserName == game.Colors["white"].UserName ? Convert.ToInt32(game.Colors["white"].Kf) : Convert.ToInt32(game.Colors["black"].Kf);            
            if (user.UserName == game.Colors["white"].UserName)
            {               
                int rating = Convert.ToInt32(game.Colors["white"].Rating);
                int dltR = rating-Convert.ToInt32(game.Colors["black"].Rating) ;
                double g = 1/Math.Sqrt(1+(3 * Math.Pow(q,2)*Math.Pow(RD,2)/Math.Pow(Math.PI,2)));                
                double Ea = 1/(1 + Math.Pow(10,g*dltR/-400));
                double d2 = Math.Pow(Math.Pow(q, 2) * Math.Pow(g, 2) * (Ea*(1-Ea)),-1);
                newRD = (int)Math.Sqrt(Math.Pow(1 / Math.Pow(RD, 2) + 1 / d2, -1));
                newRating = (int)(rating + q / (1 / Math.Pow(RD, 2) + 1 / d2) * g * (res - Ea));
            }
            else
            {                
                int rating = Convert.ToInt32(game.Colors["black"].Rating);            
                 int dltR =  rating-Convert.ToInt32(game.Colors["white"].Rating) ;                
                double g = 1 / Math.Sqrt(1 + (3 * Math.Pow(q, 2) * Math.Pow(RD, 2) / Math.Pow(Math.PI, 2)));
               
                double Ea = 1 / (1 + Math.Pow(10, g*dltR / -400));
                double d2 = Math.Pow(Math.Pow(q, 2) * Math.Pow(g, 2) * (Ea * (1 - Ea)), -1);
                newRD = (int)Math.Sqrt(Math.Pow(1 / Math.Pow(RD, 2) + 1 / d2, -1));
                newRating = (int)(rating + q / (1 / Math.Pow(RD, 2) + 1 / d2) * g * (res - Ea));
            }
            return new RG {  Rating = newRating, RD = newRD };            
        }

        public async Task<int> GetKfPlayer(GameState game,string userName)
        {            
            var user = await _userService.GetUserRatingAsync(userName);
            if (user != null)
            {
                var perfsStatistics = GetPerfsStatistics(game, user);
                return GetKfByType(perfsStatistics,user);
            }            
            return 10;            
        }
    }
}
