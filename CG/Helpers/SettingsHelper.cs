using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Security.AccessControl;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Helpers
{
    public class SettingsHelper
    {
        private const string NameInCache = "SettingsCache";
        public static string EncryptionKey { get; set; }

        public static void ClearSettings()
        {
            CacheHelper.RemoveFromCache(CacheType.Settings, "SettingsCache");
        }

        public static bool CheckSettings()
        {
            bool result = false;
            if (CacheHelper.GetFromCache(CacheType.Settings, "SettingsCache") is Dictionary<string, string> dictionary && dictionary.Count > 0)
            {
                result = true;
            }

            return result;
        }

        public static string GetSettingsValue(string section, string key)
        {
            string result = string.Empty;
            if (!CheckSettings())
            {
                InitSettings(EncryptionKey);
            }

            string key2 = section.Trim() + "/" + key.Trim();
            try
            {
                if (CacheHelper.GetFromCache(CacheType.Settings, "SettingsCache") is Dictionary<string, string> dictionary && dictionary.ContainsKey(key2))
                {
                    result = dictionary[key2]?.Trim() ?? string.Empty;
                }
            }
            catch
            {
                InitSettings(EncryptionKey);
                if (CacheHelper.GetFromCache(CacheType.Settings, "SettingsCache") is Dictionary<string, string> dictionary2 && dictionary2.ContainsKey(key2))
                {
                    result = dictionary2[key2].Trim();
                }
            }

            return result;
        }

        public static TEnum GetSettingsValueAsEnum<TEnum>(string section, string key, TEnum? defaultVal = null) where TEnum : struct
        {
            TEnum result;
            bool num = Enum.TryParse<TEnum>(GetSettingsValue(section, key), out result);
            if (!num && !defaultVal.HasValue)
            {
                throw new ArgumentException($"Не удалось привести параметр {section}.{key} к типу {"TEnum"}");
            }

            if (!num && defaultVal.HasValue)
            {
                return defaultVal.Value;
            }

            return result;
        }

        public static int GetSettingsValueAsInt(string section, string key, int? defaultValue = null)
        {
            if (!int.TryParse(GetSettingsValue(section, key), out var result) && defaultValue.HasValue)
            {
                return defaultValue.Value;
            }

            return result;
        }

        public static decimal GetSettingsValueAsDecimal(string section, string key, int? defaultValue = null)
        {
            decimal result;
            bool num = decimal.TryParse(GetSettingsValue(section, key), out result);
            if (!num && !defaultValue.HasValue)
            {
                throw new ArgumentException($"Не удалось привести параметр {section}.{key} к типу decimal");
            }

            if (!num && defaultValue.HasValue)
            {
                return defaultValue.Value;
            }

            return result;
        }

        public static int? GetSettingsValueAsNullInt(string section, string key)
        {
            if (!int.TryParse(GetSettingsValue(section, key), out var result))
            {
                return null;
            }

            return result;
        }

        public static bool GetSettingsValueAsBool(string section, string key, bool? defaultValue = null)
        {
            if (!bool.TryParse(GetSettingsValue(section, key), out var result) && defaultValue.HasValue)
            {
                return defaultValue.Value;
            }

            return result;
        }

        public static bool? GetSettingsValueAsNullableBool(string section, string key, bool? defaultValue = null)
        {
            bool result;
            bool flag = bool.TryParse(GetSettingsValue(section, key), out result);
            if (!flag && !defaultValue.HasValue)
            {
                return null;
            }

            if (!flag && defaultValue.HasValue)
            {
                return defaultValue.Value;
            }

            return result;
        }

        public static List<string> GetSettingsValueAsList(string section, string key, char separator = ',')
        {
            return (from x in GetSettingsValue(section, key).ToString().Split(new char[1] { separator }, StringSplitOptions.RemoveEmptyEntries)
                    select x.Trim()).ToList();
        }

        public static List<int> GetSettingsValueAsListInt(string section, string key, char separator = ',')
        {
            try
            {
                return (from x in GetSettingsValueAsList(section, key, separator)
                        select int.Parse(x.Trim())).ToList();
            }
            catch (Exception)
            {
                throw new ArgumentException($"Не удалось привести параметр {section}.{key} к типу List<int>");
            }
        }

        public static void InitSettings(string directorySettingsEncryptionKey)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            
            var connectionString = configuration.GetSection("Project").GetSection("projectConnection").Value;
            string directorySettingsEncryptionKey2 = directorySettingsEncryptionKey;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(new SqlConnection(connectionString))
                    .Options;
            using (AppDbContext _context = new AppDbContext(options))
            {
                CryptographyHelper cryptoHelper = new CryptographyHelper();
                dictionary = (from set in _context.Settings
                           orderby set.Section, set.Key
                           select set).ToDictionary((Settings set) => set.Section + "/" + set.Key, (Settings set) => set.Value);
                if (dictionary == null)
                {
                    throw new Exception("Settings Not Found");
                }
            }
                
            CacheHelper.RemoveFromCache(CacheType.Settings, "SettingsCache");
            CacheHelper.AddToCache(CacheType.Settings, "SettingsCache", dictionary);
        }

        public static SettingValue GetSetting(string section, string key, bool allowEmpty = true)
        {
            string settingsValue = GetSettingsValue(section, key);
            return new SettingValue(section + "/" + key, settingsValue, allowEmpty);
        }

        public static bool IsEncrypted(Settings directorySettings)
        {
            if (directorySettings != null /*&& directorySettings.IsPassword*/)
            {
                return directorySettings.Value?.StartsWith("=") ?? false;
            }

            return false;
        }
    }
}
