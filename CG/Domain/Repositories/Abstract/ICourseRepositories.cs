using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Repositories.Abstract
{
    public interface ICourseRepositories
    {
        IQueryable<Course> GetCourses();
        IQueryable<Course> GetCoursesByTrainerId(string id,int status);
        Task<IQueryable<Course>> GetPopularCoursesAsync(int count);
        Task<Course> GetCourseByIdAsync(int id);
        Task SaveCourseAsync(Course course);
        Task ChangeCourseKind(int courseId, TypeCourse type);
        Task ChangeCourseStatus(int courseId, int status);
        Task DeleteCourseAsync(int id);
    }
}
