using CG.Domain.Enum;

namespace CG.Models
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Role Role { get; set; }
    }
}
