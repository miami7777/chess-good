using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class DirectoryCategoriesRepositories : ICategoryRepositories
    {
        private readonly AppDbContext _context;

        public DirectoryCategoriesRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            _context.DirectoryCategory.Remove(new DirectoryCategory { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<DirectoryCategory> GetCategoryByIdAsync(int id)
        {
           return await _context.DirectoryCategory.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<DirectoryCategory> GetAllCategory()
        {
            return _context.DirectoryCategory.AsQueryable();
        }

        public async Task SaveCategoryAsync(DirectoryCategory category)
        {
            if (category.Id == default)
            {
                _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
