using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CG.Models.Lichess;

namespace CG.Domain.Entities
{
    public class LichessUsers
    {
        public string Id { get; set; }       
        public string Username { get; set; }       
        public string? Title { get; set; }        
        public long createdat { get; set; }        
        public long seenat { get; set; }    
        public  int? ProfileId { get; set; }
        public int? PerfsId { get; set; }
        [ForeignKey("ProfileId")]
        public virtual ProfileLichess? Profile { get; set; }
        [ForeignKey("PerfsId")]
        public virtual PerfsLichess? Perfs { get; set; }
    }
}
