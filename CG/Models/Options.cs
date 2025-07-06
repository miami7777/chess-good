using CG.Models.Enum;
using CG.Models.Enums;

namespace CG.Models
{
    public class Options
    {
        public int min {  get; set; }
        public int sec { get; set; }
        public int add_sec { get; set; }
        public Type_Game type { get; set; }
        public bool isRating { get; set; }
        public Color color { get; set; }
    }
}
