using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CG.Domain.Entities
{
    public class CourseDetails
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int ChapterId { get; set; }
        [Display(Name = "Дата создания")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("ChapterId")]
        public Chapters Chapters { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
