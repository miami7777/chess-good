using CG.Domain.Enum;

namespace CG.Domain
{
    public struct CacheInformation
    {
        //
        // Сводка:
        //     Тип истечения.
        public CacheExpirationType ExpirationType;

        //
        // Сводка:
        //     Время истечения.
        public TimeSpan Span;

        //
        // Сводка:
        //     Тип кэша.
        public CacheType Type;

        //
        // Сводка:
        //     Конструктор.
        //
        // Параметры:
        //   type:
        //
        //   span:
        //
        //   expirationType:
        public CacheInformation(CacheType type, TimeSpan span, CacheExpirationType expirationType)
        {
            Type = type;
            Span = span;
            ExpirationType = expirationType;
        }
    }
}
