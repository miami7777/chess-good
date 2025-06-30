using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CG.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name="Логин")]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string? Password { get; set; }
        [Required]
        [Display(Name = "Согласие на обработку персональных данных")]
        public bool IsApproval { get; set; }


    }
}
