using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;
using CG.Domain.Entities;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class LichessUserRepositories : ILichessUsersRepositories
    {
        private readonly AppDbContext _context;
        

        public LichessUserRepositories(AppDbContext context)
        {
            _context = context;            
        }

        public async Task DeleteUserAsync(string id)
        {
            _context.LichessUsers.Remove(new LichessUsers { Id = id});
            await _context.SaveChangesAsync();
        }
        
        public async Task<LichessUsers> GetLichessUserByIdAsync(string id)
        {
           return await _context.LichessUsers.Include(x => x.Profile).Include(x => x.Perfs).Include(x => x.Perfs.Blitz).Include(x => x.Perfs.Bullet).Include(x => x.Perfs.Classical).Include(x => x.Perfs.Rapid).FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<LichessUsers>> GetLichessUsersAsync()
        {
            return _context.LichessUsers.AsQueryable();
        }

        public async Task SaveUserAsync(LichessUsers user)
        { 
            if (user.Profile != null)
            {
                ProfileLichess profile = user.Profile;
                _context.Entry(profile).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            if (user.Perfs != null)
            {
                PerfsLichess perfs = user.Perfs;
                if (perfs.Blitz != null)
                {
                    _context.Entry(perfs.Blitz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
                if (perfs.Rapid != null)
                {
                    _context.Entry(perfs.Rapid).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
                if (perfs.Bullet != null)
                {
                    _context.Entry(perfs.Bullet).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
                if (perfs.Classical != null)
                {
                    _context.Entry(perfs.Classical).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
                _context.Entry(perfs).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(LichessUsers user)
        {
            if (user.Profile != null)
            {
                ProfileLichess profile = user.Profile;
                _context.Entry(profile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            if (user.Perfs != null)
            {
                PerfsLichess perfs = user.Perfs;
                if (perfs.Blitz != null)
                {
                    _context.Entry(perfs.Blitz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                if (perfs.Rapid != null)
                {
                    _context.Entry(perfs.Rapid).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                if (perfs.Bullet != null)
                {
                    _context.Entry(perfs.Bullet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                if (perfs.Classical != null)
                {
                    _context.Entry(perfs.Classical).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                _context.Entry(perfs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
