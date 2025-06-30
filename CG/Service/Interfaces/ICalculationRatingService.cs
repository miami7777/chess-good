using CG.Domain;
using CG.Models;
using CG.Models.Enum;

namespace CG.Service.Interfaces
{
    public interface ICalculationRatingService
    {
        Task<ApplicationUser> CalculateRatingAsync(GameState game);
        Task<int> GetRatingAsync(GameState game);
        (string,string) GetAvatarAsync(List<Player> gamePlayers);
        Task<int> GetRatingByTypeAsync(Type_Game type);
        Task<int> GetRatingByTypeAndUserAsync(Type_Game type,string username);
    }
}
