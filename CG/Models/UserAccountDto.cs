using CG.Models.Lichess;
using System.Text.Json.Serialization;

namespace CG.Models
{
    public class UserAccountDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        
        [JsonPropertyName("perfs")]
        public Perfs Perfs { get; set; }
    }
}
