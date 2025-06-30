namespace CG.Domain.Entities
{
    public class Reviews : EntityBase
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
        public int ListOrder { get; set; }
    }
}
