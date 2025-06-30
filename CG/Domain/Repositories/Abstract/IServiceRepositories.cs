using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface IServiceRepositories
    {
        Task<IQueryable<CG.Domain.Entities.Service>> GetServicesAsync();
        Task<CG.Domain.Entities.Service> GetServiceByIdAsync(int id);
        Task SaveServiceAsync(CG.Domain.Entities.Service service);
        Task DeleteServiceAsync(int id);
    }
}
