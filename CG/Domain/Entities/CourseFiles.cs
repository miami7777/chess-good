using System.ComponentModel.DataAnnotations;
using CG.Domain.Enum;

namespace CG.Domain.Entities
{
    public class CourseFiles
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int? CourseId { get; set;}
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] FileContent { get; set; }
        public Guid GUID { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UserID { get; set; }

        [StringLength(100)]
        public string FileContentType { get; set; }
        public TypeCourseFiles TypeCourseFiles { get; set; }
        public bool? OfferThumbNail { get; set; }
        public virtual Course Course { get; set; }        
    }
}
