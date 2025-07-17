using CG.Domain.Entities;
using CG.Models.Lichess;

namespace CG.Domain.Repositories.Abstract
{
    public interface IUsersRepositories
    {
        Task<IQueryable<ApplicationUser>> GetUsersAsync();
        Task<IQueryable<ApplicationUser>> GetUsersAsync(int pageIndex, string role);
        Task<IQueryable<ApplicationUser>> GetPopularUsersAsync(int count,string role);
        Task<IQueryable<ApplicationUser>> GetUsersByRoleAsync(string role);
        Task<ApplicationUser> GetUserByLichessIdAsync(string lichessId);
        Task<IQueryable<ApplicationUser>> GetStudentsByTrainerIdAsync(string trainerId);
        Task<ApplicationUser> GetUserByIdAsync(string id);
        Task<ApplicationUser?> GetUserByNameAsync(string name);
        Task<ApplicationUser?> GetUserRatingAsync(string name);
        Task SaveUserAsync(ApplicationUser user);        
        Task DeleteUserAsync(string id);
        Task CreateUserPerfsAsync(ApplicationUser user, LichessAccountDto lichessAccountDto = null);
        Task UpdateUserPerfsAsync(ApplicationUser user);
    }
}
