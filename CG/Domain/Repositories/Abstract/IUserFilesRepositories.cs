using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Repositories.Abstract
{
    public interface IUserFilesRepositories
    {
        Task<IQueryable<UserFiles>> GetUserFilesAsync();
        Task<IQueryable<UserFiles>> GetUserFilesByTypeAsync(TypeUserFiles type, string userId);        
        Task<UserFiles> GetUserFilesByIdAsync(int id);
        Task SaveUserFilesAsync(UserFiles course_files);
        Task DeleteUserFilesAsync(int id);
    }
}
