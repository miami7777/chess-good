using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class ServiceRepositories : IServiceRepositories
    {
        private readonly AppDbContext _context;

        public ServiceRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteServiceAsync(int id)
        {
            _context.Services.Remove(new CG.Domain.Entities.Service { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<CG.Domain.Entities.Service> GetServiceByIdAsync(int id)
        {
           return await _context.Services.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<CG.Domain.Entities.Service>> GetServicesAsync()
        {
            return _context.Services.AsQueryable();
        }

        public async Task SaveServiceAsync(CG.Domain.Entities.Service service)
        {
            if (service.Id == default)
            {
                _context.Entry(service).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(service).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
