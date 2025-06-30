using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Dto.ResponseMessage;
using CG.Domain.Enum;

namespace CG.Domain.Entities
{
    public class Course : EntityBase
    {       
        public int StatusId { get; set; }
        public DateTime StartTimeCourse { get; set; }
        public DateTime EndTimeCourse { get; set; }
        public TypeCourse TypeCourse { get; set; }
        public CategoryTournament CategoryTournament { get; set; }
        public int Purchases { get; set; }
        public int Duration { get; set; }  
        public int? ClockTournamentId { get; set; }
        public DateTime? DateStart { get; set; }
        public bool Rated {  get; set; }
        public int? Rounds { get; set; }
        public int? RoundInterval { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public Currency Currency { get; set; }        
        public int Views { get; set; }
        public int Likes { get; set; }
        public string? TrainerId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("StatusId")]
        public virtual DirectoryStatusCourses? DirectoryStatusCourses {  get; set; }
        [ForeignKey("TrainerId")]
        public virtual ApplicationUser? Trainer { get; set; }
        [ForeignKey("CategoryId")]
        public virtual DirectoryCategory? DirectoryCategory { get; set; }
        [ForeignKey("ClockTournamentId")]
        public virtual ClockTournament? ClockTournament { get; set; }
        public virtual ICollection<CourseDetails> CourseDetails { get; set; } = new List<CourseDetails>();
        public virtual ICollection<CourseFiles> CourseFiles { get; set;} = new List<CourseFiles>();
    }
}
