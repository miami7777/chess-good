using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface IStatusCoursesRepositories
    {
        IQueryable<DirectoryStatusCourses> GetStatusAsync();
        Task<DirectoryStatusCourses> GetStatusByIdAsync(int id);
        Task SaveStatusAsync(DirectoryStatusCourses status);
        Task DeleteStatusAsync(int id);
    }
}
