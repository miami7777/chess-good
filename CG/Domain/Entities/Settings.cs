namespace CG.Domain.Entities
{
    public class Settings : EntityBase
    {
        public string Section { get; set; }
        public string Key { get; set; }
        public string? Value { get; set; }     
    }
}
