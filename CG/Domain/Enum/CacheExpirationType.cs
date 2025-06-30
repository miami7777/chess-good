namespace CG.Domain.Enum
{
    public enum CacheExpirationType
    {
        //
        // Сводка:
        //     Абсолютное истечение (по достижению конкретного времени).
        Absolute = 1,
        //
        // Сводка:
        //     Скользящее истечение (через время после последнего запроса).
        Sliding
    }
}
