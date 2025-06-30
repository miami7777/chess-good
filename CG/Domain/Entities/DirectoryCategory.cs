namespace CG.Domain.Entities
{
    public class DirectoryCategory : EntityBase
    {
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public int ListOrder { get; set; }
        public string? Color { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
