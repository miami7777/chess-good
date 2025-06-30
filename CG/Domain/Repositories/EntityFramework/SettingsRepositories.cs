using Microsoft.EntityFrameworkCore;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class SettingsRepositories : ISettingsRepositories
    { 
        private readonly AppDbContext _context;

        public SettingsRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteSettingsAsync(string key)
        {
            _context.Settings.Remove(new Settings { Key = key});
            await _context.SaveChangesAsync();
        }

        public async Task<Settings> GetSettingsByKeyAsync(string key)
        {
           return await _context.Settings.FirstOrDefaultAsync(x => x.Key == key);            
        }

        public async Task<IQueryable<Settings>> GetSettingsAsync()
        {            
            return _context.Settings.AsQueryable();
        }
        

        public async Task SaveSettingsAsync(Settings setting)
        {
            if (setting.Id == default)
            {
                _context.Entry(setting).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(setting).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
