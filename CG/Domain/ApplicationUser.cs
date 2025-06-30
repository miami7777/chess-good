using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string GetFio() => Name + " " + Surname ;
        public string? Avatar { get; set; }
        public DateTime? DismissDate { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateBirthday { get; set; }
        public string? Country {  get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public ChessTitle? ChessTitle { get; set; }
        public int? Stage { get; set; }
        public string? Trophy { get; set; }
        public string? Profile { get; set; }
        public string? TrainerPhoto { get; set; }
        public string? PreviewTrainerPhoto { get; set; }
        public DateTime? StartStudy { get; set; }
        public DateTime? EndStudy { get; set; }
        public int? YearReceiveTitle { get; set; }
        public int? Rating { get; set; }
        public int? PerfsId { get; set; }
        public string? ProfileLichess { get; set; }
        public string? LichessUserId { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<Webinar> Webinars { get; set; } = new HashSet<Webinar>();        
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        [ForeignKey("LichessUserId")]
        public virtual LichessUsers? LichessUsers { get; set;}
        [ForeignKey("PerfsId")]
        public virtual Perfs Perfs { get; set; }
    }
}
