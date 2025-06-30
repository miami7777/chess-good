using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CG.Models
{
    public class ForgetViewModel
    {        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
    }
}
