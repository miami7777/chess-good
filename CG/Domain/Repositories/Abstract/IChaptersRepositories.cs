using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface IChaptersRepositories
    {
        Task<IQueryable<Chapters>> GetChaptersAsync();        
        Task<Chapters> GetChapterByIdAsync(int id);
        Task SaveChapterAsync(Chapters chapter);
        Task DeleteChapterAsync(int id);
    }
}
