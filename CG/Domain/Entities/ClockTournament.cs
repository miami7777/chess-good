using CG.Domain.Entities;

namespace CG.Domain.Entities
{
    public class ClockTournament : EntityBase
    {
        public int Limit { get; set; }
        public int Increment { get; set; }
    }
}
