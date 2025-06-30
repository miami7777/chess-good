using System.Text.Json.Serialization;

namespace CG.Models.Lichess
{
    public class LichessAccountDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("createdat")]
        public long createdat { get; set; }
        [JsonPropertyName("seenat")]
        public long seenat { get; set; }
        [JsonPropertyName("profile")]
        public Profile Profile {  get; set; }
        [JsonPropertyName("perfs")]
        public Perfs Perfs { get; set; }
    }
}
