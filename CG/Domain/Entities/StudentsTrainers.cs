using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CG.Domain.Entities
{
    public class StudentsTrainers
    {
        public StudentsTrainers() => CreatedDate = DateTime.UtcNow;
        [Required]
        public int Id { get; set; }
        [Required]
        public string TrainerId { get; set; }
        [Required]        
        public string StudentId { get; set; }
        [Required]
        [Display(Name = "Дата начала обучения")]
        [DataType(DataType.DateTime)]
        public DateTime DateStart { get; set; }
        [Display(Name = "Дата завершения обучения")]
        [DataType(DataType.DateTime)]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Дата создания")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("StudentId")]
        public virtual ICollection<ApplicationUser> Students { get; set; }
        [ForeignKey("TrainerId")]
        public virtual ICollection<ApplicationUser> Trainers { get; set; }
    }
}
