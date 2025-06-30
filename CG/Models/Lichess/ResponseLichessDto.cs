using System.Text.Json.Serialization;

namespace CG.Models.Lichess
{
    public class ResponseLichessDto
    {
        [JsonPropertyName("ok")]
        public bool ok { get; set; }

    }
}
