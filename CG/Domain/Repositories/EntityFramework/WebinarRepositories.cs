using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class WebinarRepositories : IWebinarRepositories
    {
        private readonly AppDbContext _context;

        public WebinarRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteWebinarAsync(int id)
        {
            _context.Webinars.Remove(new Webinar { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<Webinar> GetWebinarByIdAsync(int id)
        {
           return await _context.Webinars.Include(x => x.DirectoryStatusCourses).Include(x => x.WebinarFiles).FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<Webinar> GetWebinar()
        {            
            return _context.Webinars.Include(x => x.DirectoryStatusCourses).Include(x => x.DirectoryCategory).Include(x => x.Trainer).Include(x => x.WebinarFiles).AsQueryable();
        }

        public async Task SaveWebinarAsync(Webinar webinar)
        {
            if (webinar.Id == default)
            {
                _context.Entry(webinar).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(webinar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }

        public IQueryable<Webinar> GetWebinarByTrainerId(string trainerId,int status)
        {
            return _context.Webinars.Include(x => x.DirectoryCategory).Include(x => x.Trainer).Include(x => x.DirectoryStatusCourses)
                .Where(x => x.TrainerId == trainerId && x.StatusId == status)
                .OrderByDescending(x => x.CreatedDate).AsQueryable();
        }

        public async Task ChangeWebinarAccess(int webinarId, TypeCourse type)
        {
            var webinar = _context.Webinars.FirstOrDefault(c => c.Id == webinarId);
            if (webinar == null)
            {
                return;
            }
            webinar.TypeAccess = type;
            _context.Entry(webinar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task ChangeWebinarKind(int webinarId, TypeWebinar type)
        {
            var webinar = _context.Webinars.FirstOrDefault(c => c.Id == webinarId);
            if (webinar == null)
            {
                return;
            }
            webinar.TypeWebinar = type;
            _context.Entry(webinar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task ChangeWebinarStatus(int webinarId, int status)
        {
            var webinar = _context.Webinars.FirstOrDefault(c => c.Id == webinarId);
            if (webinar == null)
            {
                return;
            }
            webinar.StatusId = status;
            _context.Entry(webinar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
