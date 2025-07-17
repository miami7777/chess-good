
namespace CG.Models
{
    public class GameMessage
    {        
        public string Type { get; set; }
        public string? UserName { get; set; }
        public string? Country { get; set; }
        public List<Player>? Players { get; set; }
        public string? Color { get; set; }
        public Move? Move { get; set; }
        public string? Winner { get; set; }
        public GameState? gameState { get; set; }
        public List<GameState>? games { get; set; }
        public Player? Opponent { get; set; }
        public Player? PlayerOngoing { get; set; }
        public string? Fen { get; set; }
        public string? Pgn { get; set;}
        public Dictionary<string,Player> Colors { get; set; }
        public string CurrentBoard { get; set; }
        public int WhiteTime { get; set; }
        public int BlackTime { get; set; }
        public List<Moves> Moves { get; set; }
        public bool IsWhiteTurn { get; set; }
        public string Rating { get; set; }
        public string? Id { get; set; }
        public Options? Options { get; set; }
        public string Result { get; set; }
        public List<string>? ListWaiting {  get; set; } 
        public string? GameId { get; set; }

    }
}
