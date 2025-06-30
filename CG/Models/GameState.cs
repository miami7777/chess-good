namespace CG.Models
{
    public class GameState
    {
        public int Id { get; set; }
        public bool IsOngoing { get; set; }
        public string? Fen {  get; set; }
        public List<Moves> Moves { get; set; }
        public bool IsWhiteTurn { get; set; }
        public List<Player> Players { get; set; }
        public List<Player> Observers { get; set; }
        public List<string> FenArray { get; set; }
        public string Pgn { get; set; }
        public string Color { get; set; }
        public string CurrentBoard {  get; set; } 
        public int WhiteTime {  get; set; }
        public int BlackTime { get; set; }
        public Dictionary<string, Player> Colors { get; set; }
        public Player? PlayerOngoing { get; set; }
        public Options Options { get; set; }
        public string Result { get; set; }
    }
}
