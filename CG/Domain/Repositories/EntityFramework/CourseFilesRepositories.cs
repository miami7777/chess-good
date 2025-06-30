using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class CourseFilesRepositories : ICourseFilesRepositories
    {
        private readonly AppDbContext _context;

        public CourseFilesRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteCourseFilesAsync(int id)
        {
            _context.CourseFiles.Remove(new CourseFiles { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<CourseFiles> GetCourseFilesByIdAsync(int id)
        {
           return await _context.CourseFiles.FirstOrDefaultAsync(x => x.Id == id);            
        }
        public async Task<IQueryable<CourseFiles>> GetCourseFilesByTypeAsync(TypeCourseFiles type, int courseId)
        {
            return _context.CourseFiles.Where(x => x.CourseId == courseId && x.TypeCourseFiles == type).AsQueryable();
        }
        public async Task<IQueryable<CourseFiles>> GetCourseFilesAsync()
        {            
            return _context.CourseFiles.AsQueryable();
        }        

        public async Task SaveCourseFilesAsync(CourseFiles course_files)
        {
            if (course_files.Id == default)
            {
                _context.Entry(course_files).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(course_files).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }        
    }
}
