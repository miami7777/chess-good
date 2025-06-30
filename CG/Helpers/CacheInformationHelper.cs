using CG.Domain.Enum;
using CG.Domain;

namespace CG.Helpers
{
    public static class CacheInformationHelper
    {
        //
        // Сводка:
        //     Дефолтные настройки кеша.
        private static readonly List<CacheInformation> _сacheSettings = new List<CacheInformation>
    {
        new CacheInformation(CacheType.Settings, TimeSpan.FromDays(1.0), CacheExpirationType.Absolute),
        new CacheInformation(CacheType.LichessOAuth, TimeSpan.FromDays(1.0), CacheExpirationType.Absolute),
        //new CacheInformation(CacheType.LichessToken, TimeSpan.FromDays(1.0), CacheExpirationType.Absolute),
    };

        //
        // Сводка:
        //     Дефолтное значение для абсолютного кеширования.
        public static TimeSpan defAbsolute = TimeSpan.FromMinutes(5.0);

        //
        // Сводка:
        //     Дефолтное значение для плавующего кеширования.
        public static TimeSpan defSlideing = new TimeSpan(23, 59, 0);

        //
        // Сводка:
        //     Получить настройки кэша
        //
        // Параметры:
        //   type:
        //     Тип кэша.
        //
        // Возврат:
        //     Информация о кэшировании.
        public static CacheInformation GetCacheSettings(CacheType type)
        {
            return _сacheSettings.First((CacheInformation x) => x.Type == type);
        }
    }
}
