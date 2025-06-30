using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class ChapterRepositories : IChaptersRepositories
    {
        private readonly AppDbContext _context;

        public ChapterRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteChapterAsync(int id)
        {
            _context.Chapters.Remove(new Chapters { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<Chapters> GetChapterByIdAsync(int id)
        {
           return await _context.Chapters.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<Chapters>> GetChaptersAsync()
        {            
            return _context.Chapters.OrderByDescending(x => x.CreatedDate).AsQueryable();
        }        

        public async Task SaveChapterAsync(Chapters chapter)
        {
            if (chapter.Id == default)
            {
                _context.Entry(chapter).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(chapter).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
