namespace CG.Models
{
    public class Player
    {
        public string ConnectionId { get; set; }       
        public string UserName { get; set; }  
        public string Rating { get; set; }
        public string Avatar { get; set; }
        public Options Options { get; set; }
    }
}
