
namespace CG.Models
{
    public class Statistics
    {        
        public List<GameState>? gameState { get; set; }
        public List<string>? Connects { get; set; }
        public List<Player>? Players { get; set; }
        public HashSet<Player>? Users { get; set; }

    }
}
