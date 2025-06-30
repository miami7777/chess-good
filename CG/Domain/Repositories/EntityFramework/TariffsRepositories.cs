using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class TariffsRepositories : ITariffsRepositories
    {
        private readonly AppDbContext _context;

        public TariffsRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteTariffAsync(int id)
        {
            _context.Tariffs.Remove(new Tariffs { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<Tariffs> GetTariffByIdAsync(int id)
        {
            return await _context.Tariffs.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<Tariffs>> GetTariffsAsync()
        {
            return _context.Tariffs.Include(x => x.Services).AsQueryable();
        }

        public async Task SaveTariffAsync(Tariffs tariff)
        {
            if (tariff.Id == default)
            {
                _context.Entry(tariff).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(tariff).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
