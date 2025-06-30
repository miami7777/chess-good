namespace CG.Domain
{
    public class SettingValue
    {
        private readonly string _name;

        private readonly string _value;

        private readonly bool _allowEmpty;

        public SettingValue(string name, string value, bool allowEmpty)
        {
            _name = name;
            _value = value;
            _allowEmpty = allowEmpty;
        }

        public static implicit operator int(SettingValue setting)
        {
            return ConvertToInt(setting);
        }

        public static implicit operator bool(SettingValue setting)
        {
            return ConvertToBool(setting);
        }

        public static implicit operator int?(SettingValue setting)
        {
            return ConvertToNullableInt(setting);
        }

        public static implicit operator bool?(SettingValue setting)
        {
            return ConvertToNullableBool(setting);
        }

        public static implicit operator string(SettingValue setting)
        {
            return setting._value;
        }

        private static int ConvertToInt(SettingValue settingValue)
        {
            GuardEmpty(settingValue._name, int.TryParse(settingValue._value, out var result), settingValue._allowEmpty);
            return result;
        }

        private static int? ConvertToNullableInt(SettingValue settingValue)
        {
            int result;
            bool flag = int.TryParse(settingValue._value, out result);
            if (!flag)
            {
                GuardEmpty(settingValue._name, flag, settingValue._allowEmpty);
                return null;
            }

            return result;
        }

        private static bool ConvertToBool(SettingValue settingValue)
        {
            GuardEmpty(settingValue._name, bool.TryParse(settingValue._value, out var result), settingValue._allowEmpty);
            return result;
        }

        private static bool? ConvertToNullableBool(SettingValue settingValue)
        {
            bool result;
            bool flag = bool.TryParse(settingValue._value, out result);
            if (!flag)
            {
                GuardEmpty(settingValue._name, flag, settingValue._allowEmpty);
                return null;
            }

            return result;
        }

        private static void GuardEmpty(string settingName, bool parseResult, bool allowEmpty)
        {
            if (!parseResult && !allowEmpty)
            {
                throw new InvalidOperationException("Значение настройки '" + settingName + "' имеет неверное значение.");
            }
        }
    }
}
