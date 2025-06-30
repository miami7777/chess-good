namespace CG.Models.Lichess
{
    public class Perfs
    {
        public PerfsStatistics? Blitz { get; set; }
        public PerfsStatistics? Rapid { get; set; }
        public PerfsStatistics? Bullet { get; set; }
        public PerfsStatistics? Classical { get; set; }
    }
    public class UserPerfs
    {
        public PerfsStatistics? Blitz { get; set; }
        public PerfsStatistics? BlitzInc { get; set; }
        public PerfsStatistics? Rapid { get; set; }
        public PerfsStatistics? RapidInc { get; set; }
        public PerfsStatistics? Bullet { get; set; }
        public PerfsStatistics? BulletInc { get; set; }
        public PerfsStatistics? Classical { get; set; }
        public PerfsStatistics? ClassicalInc { get; set; }
    }
    public class PerfsStatistics
    {
        public int Games { get; set; }
        public int Rating { get; set; }
        public int RD { get; set; }
        public int Prog {  get; set; }
        public bool Prov {  get; set; }
    }
}
