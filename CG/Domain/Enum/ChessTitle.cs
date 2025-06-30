using System.ComponentModel;

namespace CG.Domain.Enum
{
    public enum ChessTitle
    {
        [Description("Без звания")]
        None,
        [Description("1 разряд взрослый")]
        Category1,
        [Description("1 разряд юношеский")]
        CategoryYoung1,
        [Description("2 разряд взрослый")]
        Category2,
        [Description("2 разряд юношеский")]
        CategoryYoung2,
        [Description("3 разряд взрослый")]
        Category3,
        [Description("3 разряд юношеский")]
        CategoryYoung3,
        [Description("Женский кандидат в мастера")]
        WCM,
        [Description("Кандидат в мастера")]
        CM,
        [Description("Национальный мастер")]
        WNM,
        [Description("Женский национальный мастер")]
        NM,
        [Description("FIDE мастер")]
        FM,
        [Description("Международный мастер")]
        IM,
        [Description("Женский FIDE мастер")]
        WFM,
        [Description("Женский международный мастер")]
        WIM,
        [Description("Женский гроссмейстер")]
        WGM,
        [Description("Гроссмейстер")]
        GM,
        [Description("Международный арбитр")]
        ИА,
        [Description("Арбитр ФИДЕ")]
        АФ,
        [Description("Старший тренер ФИДЕ")]
        FST,
        [Description("Тренер ФИДЕ")]
        FT,
        [Description("Инструктор ФИДЕ")]
        FI,
        [Description("Национальный инструктор")]
        NI,
        [Description("Инструктор по развитию")]
        DI,
        [Description("Международный организатор ФИДЕ")]
        FIO
    }
}
