using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Domain.Repositories.Abstract;
using CG.Models.Lichess;

namespace CG.Domain.Repositories.EntityFramework
{
    public class UserRepositories : IUsersRepositories
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepositories(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task DeleteUserAsync(string id)
        {
            _context.Users.Remove(new ApplicationUser { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<ApplicationUser>> GetUsersByRoleAsync(string role)
        {
            var users = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Where(x => x.UserRoles.Select(x => x.Role.Name).Contains(role)).ToList();
            return users.AsQueryable();
        }
        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
           return await _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<ApplicationUser>> GetUsersAsync()
        {
            return _context.Users.Include(x => x.UserRoles).AsQueryable();
        }

        public async Task SaveUserAsync(ApplicationUser user)
        {
            if (user.Id == default)
            {
                _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<ApplicationUser>> GetPopularUsersAsync(int count,string role)
        {
            return _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Where(x => x.UserRoles.Select(x => x.Role.Name).Contains(role)).Take(count).AsQueryable();
        }

        public async Task<IQueryable<ApplicationUser>> GetUsersAsync(int pageIndex, string role)
        {
            int take = 10;
            int skip = take*(pageIndex-1);            
            return _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Where(x => x.UserRoles.Select(x => x.Role.Name).Contains(role)).Skip(skip).Take(10).AsQueryable();
        }

        public async Task<ApplicationUser?> GetUserByNameAsync(string name)
        {
           return await _context.Users.Include(x => x.Courses).Include(x => x.Webinars).Include(x => x.Perfs).ThenInclude(x => x.Blitz).Include(x => x.Perfs).ThenInclude(x => x.Bullet).Include(x => x.Perfs).ThenInclude(x => x.Rapid).Include(x => x.Perfs).ThenInclude(x => x.Classical)
                .Include(x => x.Perfs).ThenInclude(x => x.BlitzInc).Include(x => x.Perfs).ThenInclude(x => x.BulletInc).Include(x => x.Perfs).ThenInclude(x => x.RapidInc).Include(x => x.Perfs).ThenInclude(x => x.ClassicalInc)
                .Include(x => x.UserRoles).ThenInclude(x => x.Role).FirstOrDefaultAsync(u => u.UserName == name);
        }
        public async Task<ApplicationUser?> GetUserRatingAsync(string name)
        {
            var res = await _context.Users.Include(x => x.Perfs).ThenInclude(x => x.Blitz).Include(x => x.Perfs).ThenInclude(x => x.Rapid).Include(x => x.Perfs).ThenInclude(x => x.Bullet)
                .Include(x => x.Perfs).ThenInclude(x => x.Classical).Include(x => x.Perfs).ThenInclude(x => x.BlitzInc).Include(x => x.Perfs).ThenInclude(x => x.BulletInc).Include(x => x.Perfs).ThenInclude(x => x.RapidInc).Include(x => x.Perfs).ThenInclude(x => x.ClassicalInc)
                .FirstOrDefaultAsync(u => u.UserName == name);
            return res;
        }

        public async Task<IQueryable<ApplicationUser>> GetStudentsByTrainerIdAsync(string trainerId)
        {
            return _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).AsQueryable();
        }

        public async Task<ApplicationUser> GetUserByLichessIdAsync(string lichessId)
        {
           return  await _context.Users.FirstOrDefaultAsync(u => u.ProfileLichess.ToLower() == lichessId);
        }

        public async Task CreateUserPerfsAsync(ApplicationUser user, LichessAccountDto? lichessAccountDto = null)
        { 
            var UserPerfs = new Entities.Perfs
            {
                Id = 0,
                Blitz = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.Blitz?.Games == null || user.Perfs?.Blitz?.Games == 0) ? lichessAccountDto.Perfs?.Blitz.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.Blitz?.Games == null || user.Perfs?.Blitz?.Games == 0) ? lichessAccountDto.Perfs?.Blitz.Rating ?? 1500 : 1500,
                },
                BlitzInc = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.BlitzInc?.Games == null || user.Perfs?.BlitzInc?.Games == 0) ? lichessAccountDto.Perfs?.Blitz.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.BlitzInc?.Games == null || user.Perfs?.BlitzInc?.Games == 0) ? lichessAccountDto.Perfs?.Blitz.Rating ?? 1500 : 1500,
                },
                Rapid = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.Rapid?.Games == null || user.Perfs?.Rapid?.Games == 0) ? lichessAccountDto.Perfs?.Rapid.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.Rapid?.Games == null || user.Perfs?.Rapid?.Games == 0) ? lichessAccountDto.Perfs?.Rapid.Rating ?? 1500 : 1500,
                },
                RapidInc = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.RapidInc?.Games == null || user.Perfs?.RapidInc?.Games == 0) ? lichessAccountDto.Perfs?.Rapid.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.RapidInc?.Games == null || user.Perfs?.RapidInc?.Games == 0) ? lichessAccountDto.Perfs?.Rapid.Rating ?? 1500 : 1500,
                },
                Bullet = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.Bullet?.Games == null || user.Perfs?.Bullet?.Games == 0) ? lichessAccountDto.Perfs?.Bullet.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.Bullet?.Games == null || user.Perfs?.Bullet?.Games == 0) ? lichessAccountDto.Perfs?.Bullet.Rating ?? 1500 : 1500,
                },
                BulletInc = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.BulletInc?.Games == null || user.Perfs?.BulletInc?.Games == 0) ? lichessAccountDto.Perfs?.Bullet.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.BulletInc?.Games == null || user.Perfs?.BulletInc?.Games == 0) ? lichessAccountDto.Perfs?.Bullet.Rating ?? 1500 : 1500,
                },
                Classical = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.Classical?.Games == null || user.Perfs?.Classical?.Games == 0) ? lichessAccountDto.Perfs?.Classical.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.Classical?.Games == null || user.Perfs?.Classical?.Games == 0) ? lichessAccountDto.Perfs?.Classical.Rating ?? 1500 : 1500,
                },
                ClassicalInc = new Entities.PerfsStatistics()
                {
                    Games = lichessAccountDto != null && (user.Perfs?.ClassicalInc?.Games == null || user.Perfs?.ClassicalInc?.Games == 0) ? lichessAccountDto.Perfs?.Classical.Games ?? 0 : 0,
                    Rating = lichessAccountDto != null && (user.Perfs?.ClassicalInc?.Games == null || user.Perfs?.ClassicalInc?.Games == 0) ? lichessAccountDto.Perfs?.Classical.Rating ?? 1500 : 1500,
                }
            };
            
            
                user.Perfs = UserPerfs;
                if (UserPerfs.Blitz != null)
                {
                    _context.Entry(UserPerfs.Blitz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            if (UserPerfs.BlitzInc != null)
            {
                _context.Entry(UserPerfs.BlitzInc).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            if (UserPerfs.Rapid != null)
                {
                    _context.Entry(UserPerfs.Rapid).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            if (UserPerfs.RapidInc != null)
            {
                _context.Entry(UserPerfs.RapidInc).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            if (UserPerfs.Bullet != null)
                {
                    _context.Entry(UserPerfs.Bullet).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            if (UserPerfs.BulletInc != null)
            {
                _context.Entry(UserPerfs.BulletInc).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            if (UserPerfs.Classical != null)
                {
                    _context.Entry(UserPerfs.Classical).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            if (UserPerfs.ClassicalInc != null)
            {
                _context.Entry(UserPerfs.ClassicalInc).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            _context.Entry(UserPerfs).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
