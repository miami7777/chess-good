using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Entities
{
    public class Webinar : EntityBase
    {
        public int StatusId { get; set; }
        public TypeWebinar TypeWebinar { get; set; }
        public TypeCourse TypeAccess { get; set; }
        public DateTime StartTimeWebinar { get; set; }
        public DateTime EndTimeWebinar{ get; set; }
        public int Purchases { get; set; }
        public int AvailableSeats { get; set; }
        public int Duration { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public Currency Currency { get; set; }        
        public int Views { get; set; }
        public int Likes { get; set; }
        public string TrainerId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("StatusId")]
        public virtual DirectoryStatusCourses? DirectoryStatusCourses { get; set; }
        [ForeignKey("TrainerId")]
        public virtual ApplicationUser? Trainer { get; set; }
        [ForeignKey("CategoryId")]
        public virtual DirectoryCategory? DirectoryCategory { get; set; }        
        public virtual ICollection<WebinarFiles> WebinarFiles { get; set; } = new List<WebinarFiles>();
    }
}
