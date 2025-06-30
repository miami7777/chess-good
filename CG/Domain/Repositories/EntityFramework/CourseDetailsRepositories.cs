using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class CourseDetailsRepositories : ICourseDetailsRepositories
    {
        private readonly AppDbContext _context;

        public CourseDetailsRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteCourseDetailsAsync(int id)
        {
            _context.CourseDetails.Remove(new CourseDetails { Id = id});
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCourseDetailsAsync(CourseDetails courseDetails)
        {
            _context.CourseDetails.Remove(courseDetails);
            await _context.SaveChangesAsync();
        }
        public async Task<CourseDetails> GetCourseDetailsByIdAsync(int id)
        {
           return await _context.CourseDetails.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<CourseDetails>> GetCourseDetailsAsync()
        {            
            return _context.CourseDetails.OrderByDescending(x => x.CreatedDate).AsQueryable();
        }        

        public async Task SaveCourseDetailsAsync(CourseDetails course_details)
        {
            if (course_details.Id == default)
            {
                _context.Entry(course_details).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(course_details).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
