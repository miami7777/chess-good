using CG.Domain.Entities;

namespace CG.Domain.Entities
{
    public class PerfsStatistics
    {
        public int Id { get; set; }
        public int Games { get; set; }
        public int Rating { get; set; }
        public int RD { get; set; }
        public int Prog { get; set; }
        public bool Prov { get; set; }
    }
}
