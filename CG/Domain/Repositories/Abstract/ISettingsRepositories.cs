using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ISettingsRepositories
    {
        Task<IQueryable<Settings>> GetSettingsAsync();
        Task<Settings> GetSettingsByKeyAsync(string key);
        Task SaveSettingsAsync(Settings settings);
        Task DeleteSettingsAsync(string key);
    }
}
