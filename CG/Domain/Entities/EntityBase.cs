using System.ComponentModel.DataAnnotations;

namespace CG.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => CreatedDate = DateTime.UtcNow;
        [Required]        
        public int Id { get; set; }
        [Display(Name="Наименование")]
        public virtual string Name { get; set; }
        [Display(Name = "Описание")]
        public virtual string Description { get; set; }
        [Display(Name="Дата создания")]
        [DataType(DataType.DateTime)]
        public virtual DateTime CreatedDate { get; set;}
    }
}
