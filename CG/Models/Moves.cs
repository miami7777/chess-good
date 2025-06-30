namespace CG.Models
{
    public class Moves
    {
        public string From { get; set; }
        public string To { get; set; }
        public string PieceType { get; set; }
        public string PieceColor { get; set; }
        public bool Captured { get; set; }
        public string? PromotedTo { get; set; }
    }
}
