using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class UserFilesRepositories : IUserFilesRepositories
    {
        private readonly AppDbContext _context;

        public UserFilesRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteUserFilesAsync(int id)
        {
            _context.UserFiles.Remove(new UserFiles { Id = id });
            await _context.SaveChangesAsync();
        }

        public async Task<UserFiles> GetUserFilesByIdAsync(int id)
        {
            return await _context.UserFiles.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<IQueryable<UserFiles>> GetUserFilesByTypeAsync(TypeUserFiles type, string userId)
        {
            return _context.UserFiles.Where(x => x.UserId == userId && x.TypeUserFiles == type).AsQueryable();
        }
        public async Task<IQueryable<UserFiles>> GetUserFilesAsync()
        {
            return _context.UserFiles.AsQueryable();
        }

        public async Task SaveUserFilesAsync(UserFiles user_files)
        {
            if (user_files.Id == default)
            {
                _context.Entry(user_files).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(user_files).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }        
    }
}
