using System.Text.Json.Serialization;

namespace CG.Models.Lichess
{
    public class RequestLichessDto
    {
        [JsonPropertyName("text")]
        public string text { get; set; }

    }
}
