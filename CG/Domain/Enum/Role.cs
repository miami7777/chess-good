using System.ComponentModel;

namespace CG.Domain.Enum
{
    public enum Role
    {
        [Description("Админ")]
        admin,
        [Description("Преподаватель")]
        trainer,
        [Description("Студент")]
        student,
        [Description("Пользователь")]
        user
    }
}
