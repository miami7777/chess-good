using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class StatusCoursesRepositories : IStatusCoursesRepositories
    {
        private readonly AppDbContext _context;

        public StatusCoursesRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteStatusAsync(int id)
        {
            _context.DirectoryStatusCourses.Remove(new DirectoryStatusCourses { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<DirectoryStatusCourses> GetStatusByIdAsync(int id)
        {
           return await _context.DirectoryStatusCourses.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<DirectoryStatusCourses> GetStatusAsync()
        {
            return _context.DirectoryStatusCourses.AsQueryable();
        }

        public async Task SaveStatusAsync(DirectoryStatusCourses status)
        {
            if (status.Id == default)
            {
                _context.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
