using System.ComponentModel.DataAnnotations.Schema;

namespace CG.Domain.Entities
{
    public class Chapters : EntityBase
    {
        public string NavigationTitle { get; set; }
        public string Header { get; set; }
        public int? ChapterPreviewId { get; set; }
        public int? ChapterVideoId { get; set; }       
        public virtual CourseFiles? ChapterPreview { get; set; }        
        public virtual CourseFiles? ChapterVideo { get; set; }
    }
}
