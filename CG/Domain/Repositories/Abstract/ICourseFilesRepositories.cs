using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Repositories.Abstract
{
    public interface ICourseFilesRepositories
    {
        Task<IQueryable<CourseFiles>> GetCourseFilesAsync();
        Task<IQueryable<CourseFiles>> GetCourseFilesByTypeAsync(TypeCourseFiles type, int courseId);        
        Task<CourseFiles> GetCourseFilesByIdAsync(int id);
        Task SaveCourseFilesAsync(CourseFiles course_files);
        Task DeleteCourseFilesAsync(int id);
    }
}
