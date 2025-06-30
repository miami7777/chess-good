using CG.Domain.Entities;
using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface IClockTournamentsRepositories
    {
        IQueryable<ClockTournament> GetAllClockTournaments();
        Task<ClockTournament> GetClockTournamentByIdAsync(int id);
        Task SaveClockTournamentAsync(ClockTournament clock);
        Task DeleteClockTournamentAsync(int id);
    }
}
