using CG.Domain.Entities;
using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Repositories.Abstract
{
    public interface IWebinarFilesRepositories
    {
        Task<IQueryable<WebinarFiles>> GetWebinarFilesAsync();
        Task<IQueryable<WebinarFiles>> GetWebinarFilesByTypeAsync(TypeWebinarFiles type, int webinarId);        
        Task<WebinarFiles> GetWebinarFilesByIdAsync(int id);
        Task SaveWebinarFilesAsync(WebinarFiles course_files);
        Task DeleteWebinarFilesAsync(int id);
    }
}
