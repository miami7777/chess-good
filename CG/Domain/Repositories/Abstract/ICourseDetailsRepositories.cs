using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ICourseDetailsRepositories
    {
        Task<IQueryable<CourseDetails>> GetCourseDetailsAsync();        
        Task<CourseDetails> GetCourseDetailsByIdAsync(int id);
        Task SaveCourseDetailsAsync(CourseDetails course_details);
        Task DeleteCourseDetailsAsync(int id);
        Task DeleteCourseDetailsAsync(CourseDetails courseDetails);
    }
}
