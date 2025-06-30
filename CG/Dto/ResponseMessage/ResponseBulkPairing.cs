using Humanizer;
using Microsoft.CodeAnalysis;
using CG.Models.Enum;

namespace CG.Dto.ResponseMessage
{
    public class ResponseBulkPairing
    {
        public string Id { get; set; }
        public List<Games>? Games { get; set; }
        public VariantKey Variant {  get; set; }
        public Clock? Clock { get; set; }
        public int PairAt {  get; set; }
        public long PairedAt { get; set; }
        public bool Rated { get; set; }
        public long startClocksAt { get; set; }
        public long scheduledAt { get;set; }
    }
    public class Games
    {
        public string Id { get; set; }
        public string? Black { get; set; }
        public string? White { get; set; }
    }
    public class Clock
    {
        public int increment { get; set; }
        public int limit { get; set; }
    }
}
