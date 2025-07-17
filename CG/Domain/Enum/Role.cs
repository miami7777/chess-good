using System.ComponentModel;

namespace CG.Domain.Enum
{
    public enum Role
    {
        [Description("Админ")]
        admin,
        [Description("Организатор")]
        organizer,
        [Description("Пользователь")]
        user,
        [Description("Член клуба")]
        member,
        [Description("Спортсмен")]
        sportsman
    }
}
