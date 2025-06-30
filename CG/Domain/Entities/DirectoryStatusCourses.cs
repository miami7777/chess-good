using System.ComponentModel.DataAnnotations;

namespace CG.Domain.Entities
{
    public class DirectoryStatusCourses : EntityBase
    {        

        [StringLength(100)]
        public string? EngName { get; set; }
        [StringLength(100)]
        public string? RusName { get; set; }
        public int ListOrder { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
