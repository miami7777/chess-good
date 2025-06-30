using Microsoft.EntityFrameworkCore;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class WebinarFilesRepositories : IWebinarFilesRepositories
    {
        private readonly AppDbContext _context;

        public WebinarFilesRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteWebinarFilesAsync(int id)
        {
            _context.WebinarFiles.Remove(new WebinarFiles { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<WebinarFiles> GetWebinarFilesByIdAsync(int id)
        {
           return await _context.WebinarFiles.FirstOrDefaultAsync(x => x.Id == id);            
        }
        public async Task<IQueryable<WebinarFiles>> GetWebinarFilesByTypeAsync(TypeWebinarFiles type, int webinarId)
        {
            return _context.WebinarFiles.Where(x => x.WebinarId == webinarId && x.TypeWebinarFiles == type).AsQueryable();
        }
        public async Task<IQueryable<WebinarFiles>> GetWebinarFilesAsync()
        {            
            return _context.WebinarFiles.AsQueryable();
        }        

        public async Task SaveWebinarFilesAsync(WebinarFiles webinar_files)
        {
            if (webinar_files.Id == default)
            {
                _context.Entry(webinar_files).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(webinar_files).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }        
    }
}
