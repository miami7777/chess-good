using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class ClockTournamentsRepositories : IClockTournamentsRepositories
    {
        private readonly AppDbContext _context;

        public ClockTournamentsRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteClockTournamentAsync(int id)
        {
            _context.ClockTournament.Remove(new ClockTournament { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<ClockTournament> GetClockTournamentByIdAsync(int id)
        {
           return await _context.ClockTournament.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<ClockTournament> GetAllClockTournaments()
        {
            return _context.ClockTournament.AsQueryable();
        }

        public async Task SaveClockTournamentAsync(ClockTournament clock)
        {
            if (clock.Id == default)
            {
                _context.Entry(clock).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(clock).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
