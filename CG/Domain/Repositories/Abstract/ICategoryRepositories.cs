using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ICategoryRepositories
    {
        IQueryable<DirectoryCategory> GetAllCategory();
        Task<DirectoryCategory> GetCategoryByIdAsync(int id);
        Task SaveCategoryAsync(DirectoryCategory category);
        Task DeleteCategoryAsync(int id);
    }
}
