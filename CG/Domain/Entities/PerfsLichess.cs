using System.ComponentModel.DataAnnotations.Schema;
using CG.Models.Lichess;
using CG.Domain.Entities;

namespace CG.Domain.Entities
{
    public class PerfsLichess
    {
        public int Id { get; set; }
        public int? BlitzId { get; set; }
        public int? RapidId { get; set; }
        public int? BulletId { get; set; }
        public int? ClassicalId { get; set; }
        [ForeignKey("BlitzId")]
        public virtual PerfsStatisticsLichess? Blitz { get; set; }
        [ForeignKey("RapidId")]
        public virtual PerfsStatisticsLichess? Rapid { get; set; }
        [ForeignKey("BulletId")]
        public virtual PerfsStatisticsLichess? Bullet { get; set; }
        [ForeignKey("ClassicalId")]
        public virtual PerfsStatisticsLichess? Classical { get; set; }
    }
}
