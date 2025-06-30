using Microsoft.EntityFrameworkCore;

namespace CG.Domain.Entities
{
    public class Service : EntityBase
    {
        public override string? Description {  get; set; }
    }
}
