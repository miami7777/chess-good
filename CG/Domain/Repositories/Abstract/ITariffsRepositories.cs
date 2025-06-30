using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ITariffsRepositories
    {
        Task<IQueryable<Tariffs>> GetTariffsAsync();
        Task<Tariffs> GetTariffByIdAsync(int id);
        Task SaveTariffAsync(Tariffs service);
        Task DeleteTariffAsync(int id);
    }
}
