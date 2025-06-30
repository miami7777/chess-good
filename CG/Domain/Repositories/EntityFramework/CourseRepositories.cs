using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class CourseRepositories : ICourseRepositories
    {
        private readonly AppDbContext _context;

        public CourseRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task ChangeCourseKind(int courseId, TypeCourse type)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                return;
            }
            course.TypeCourse = type;
            _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task ChangeCourseStatus(int courseId, int status)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                return;
            }
            course.StatusId = status;
            _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();        
    }

        public async Task DeleteCourseAsync(int id)
        {
            _context.Courses.Remove(new Course { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
           return await _context.Courses.Include(x => x.Trainer)
                .Include(x => x.DirectoryCategory)
                .Include(x => x.DirectoryStatusCourses)
                .Include(x => x.CourseFiles)
                .Include(x => x.CourseDetails).ThenInclude(x => x.Chapters).FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<Course> GetCourses()
        {            
            return _context.Courses.Include(x => x.DirectoryCategory)
                .Include(x => x.Trainer)
                .Include(x => x.DirectoryStatusCourses)
                .Include(x => x.CourseFiles)
                .OrderByDescending(x => x.CreatedDate).AsQueryable();
        }

        public IQueryable<Course> GetCoursesByTrainerId(string id,int status)
        {
            return _context.Courses.Include(x => x.DirectoryCategory).Include(x => x.Trainer).Include(x => x.DirectoryStatusCourses)
                .Where(x => x.TrainerId == id && x.StatusId == status)
                .OrderByDescending(x => x.CreatedDate).AsQueryable();
        }

        public async Task<IQueryable<Course>> GetPopularCoursesAsync(int count)
        {
            return _context.Courses.Include(x => x.CourseFiles).Where(x => x.StatusId == 5).OrderByDescending(x => x.Views).Take(count).AsQueryable();
        }

        public async Task SaveCourseAsync(Course course)
        {
            if (course.Id == default)
            {
                _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
