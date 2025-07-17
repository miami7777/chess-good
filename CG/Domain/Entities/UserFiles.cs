using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CG.Domain.Enum;

namespace CG.Domain.Entities
{
    public class UserFiles
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string UserId { get; set;}
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] FileContent { get; set; }
        public Guid GUID { get; set; }
        public DateTime CreateDate { get; set; }       

        [StringLength(100)]
        public string FileContentType { get; set; }
        public TypeUserFiles TypeUserFiles { get; set; }
        public bool? OfferThumbNail { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }        
    }
}
