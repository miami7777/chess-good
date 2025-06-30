using System.Text.Json.Serialization;
using CG.Models.Enum;

namespace CG.Dto.RequestMessage
{
    public class RequestBulkPairing
    {
        [JsonPropertyName("players")]
        public string? players { get; set; }
        [JsonPropertyName("clock.limit")]
        public int clockLimit { get; set; }
        [JsonPropertyName("clock.increment")]
        public int clockIncrement { get; set; }
       /* [JsonPropertyName("days")]
        public int days { get; set; }
       */
        [JsonPropertyName("pairAt")]
        public long PairAt {  get; set; }
        [JsonPropertyName("startClocksAt")]
        public long StartClocksAt {  get; set; }
       /* [JsonPropertyName("rated")]
        public bool Rated { get; set; }*/
        [JsonPropertyName("variant")]
        public string? Variant {  get; set; }
       /* [JsonPropertyName("fen")]
        public string? FEN { get; set; }*/
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("rules")]
        public string? Rules { get; set; }
    }
}
