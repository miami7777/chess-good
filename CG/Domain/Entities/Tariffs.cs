using Microsoft.EntityFrameworkCore;

namespace CG.Domain.Entities
{
    public class Tariffs : EntityBase
    {
        [Precision(18, 2)]
        public decimal? PriceMonth { get; set; }
        [Precision(18, 2)]
        public decimal? PriceYear { get; set; }
        public string? ServicesIds { get; set; }
        public bool IsAdvanced { get; set; }
        public bool IsFeatured { get; set; }
        public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();
    }
}
