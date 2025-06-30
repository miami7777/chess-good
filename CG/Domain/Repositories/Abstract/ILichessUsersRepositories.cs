using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ILichessUsersRepositories
    {
        Task<IQueryable<LichessUsers>> GetLichessUsersAsync();              
        Task<LichessUsers> GetLichessUserByIdAsync(string id);        
        Task SaveUserAsync(LichessUsers user);
        Task UpdateUserAsync(LichessUsers user);
        Task DeleteUserAsync(string id);
    }
}
