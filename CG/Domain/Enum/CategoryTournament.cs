using System.ComponentModel;

namespace CG.Domain.Enum
{
    public enum CategoryTournament
    {
        [Description("Турнир Arena")]
        Arena,
        [Description("Турнир Швейцарка")]
        Swiss,
        [Description("Турнир Нокаут")]
        Knockout,
        [Description("Битва двух команд")]
        Battle,
        [Description("Мегабитва")]
        MegaBattle,
        [Description("Игра с подписчиками")]
        GameQueues,
        [Description("Матч стримеров")]
        Match,
        [Description("Игры зодиаков")]
        ZodiacGame,
        [Description("Сеанс одновременной игры")]
        Simul,
        [Description("Лига")]
        Liga,
        [Description("Тематический турнир")]
        Tematic,
        [Description("Лига чемпионов")]
        LCH,
    }
}
