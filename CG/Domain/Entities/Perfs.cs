using System.ComponentModel.DataAnnotations.Schema;
using CG.Models.Lichess;
using CG.Domain.Entities;

namespace CG.Domain.Entities
{
    public class Perfs
    {
        public int Id { get; set; }
        public int? BlitzId { get; set; }
        public int? BlitzIncId { get; set; }
        public int? RapidId { get; set; }
        public int? RapidIncId { get; set; }
        public int? BulletId { get; set; }
        public int? BulletIncId { get; set; }
        public int? ClassicalId { get; set; }
        public int? ClassicalIncId { get; set; }
        [ForeignKey("BlitzId")]
        public virtual PerfsStatistics? Blitz { get; set; }
        [ForeignKey("RapidId")]
        public virtual PerfsStatistics? Rapid { get; set; }
        [ForeignKey("BulletId")]
        public virtual PerfsStatistics? Bullet { get; set; }
        [ForeignKey("ClassicalId")]
        public virtual PerfsStatistics? Classical { get; set; }
        [ForeignKey("BlitzIncId")]
        public virtual PerfsStatistics? BlitzInc { get; set; }
        [ForeignKey("RapidIncId")]
        public virtual PerfsStatistics? RapidInc { get; set; }
        [ForeignKey("BulletIncId")]
        public virtual PerfsStatistics? BulletInc { get; set; }
        [ForeignKey("ClassicalIncId")]
        public virtual PerfsStatistics? ClassicalInc { get; set; }
    }
}
