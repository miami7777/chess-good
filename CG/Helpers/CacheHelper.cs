using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System.Security.AccessControl;
using CG.Domain;
using CG.Domain.Enum;

namespace CG.Helpers
{
    public class CacheHelper
    {
        private const string CacheName = "CacheHelper";

        private static MemoryCache _cache = new MemoryCache(new MemoryCacheOptions { SizeLimit = 1024 });

        public static void AddToCache(CacheType Type, string key, object obj)
        {
            CacheInformation cacheSettings = CacheInformationHelper.GetCacheSettings(Type);
            AddToCache(key, obj, cacheSettings);
        }

        public static void ClearCache()
        {
            _cache.Dispose();
            _cache = new MemoryCache(new MemoryCacheOptions { SizeLimit = 1024 });
        }

        public static object GetFromCache(CacheType Type, string key)
        {
            return _cache.Get(string.Concat(Type, key));
        }

        public static void RemoveFromCache(CacheType Type, string key)
        {
            _cache.Remove(string.Concat(Type, key));
        }

        public static Dictionary<string, byte[]> Keys()
        {
            Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
            object fromCache = GetFromCache(CacheType.Settings, "dbTbl_Keys");
            if (fromCache == null)
            {
                dictionary = fromCache as Dictionary<string, byte[]>;

                RemoveFromCache(CacheType.Settings, "dbTbl_Keys");
                AddToCache(CacheType.Settings, "dbTbl_Keys", dictionary);
            }
            else
            {
                dictionary = fromCache as Dictionary<string, byte[]>;
            }

            return dictionary;
        }

        public static void AddToCache(string key, object obj, CacheInformation cacheSettings)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                    .SetPriority(CacheItemPriority.Normal)
                    .SetSize(1024);
            if (cacheSettings.ExpirationType == CacheExpirationType.Absolute)
            {               
                _cache.Set(string.Concat(cacheSettings.Type, key), obj, cacheEntryOptions);
            }
            else
            {
                _cache.Set(string.Concat(cacheSettings.Type, key), obj, cacheEntryOptions);
            }
        }

        public static T GetFromCache<T>(CacheType Type, string key)
        {
            return (T)GetFromCache(Type, key);
        }
    }
}
