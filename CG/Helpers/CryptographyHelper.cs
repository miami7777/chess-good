using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;

namespace CG.Helpers
{
    public class CryptographyHelper : ICryptographyHelper
    {
        private const int IV_SIZE = 16;

        private const int ENCRYPTIONKEY_SIZE = 16;

        private const int ITERATIONS = 10000;

        private const int SALT_SIZE = 32;

        private const int HASH_SIZE = 32;

        private const string HardcodedSalt = "#_$$995Ge";

    //    private readonly Dictionary<KeyType, int> _keySizes = new Dictionary<KeyType, int>
    //{
    //    {
    //        KeyType.Encryption,
    //        16
    //    },
    //    {
    //        KeyType.Validation,
    //        32
    //    },
    //    {
    //        KeyType.IV,
    //        16
    //    }
    //};

        //
        // Сводка:
        //     Засолить и захэшировать пароль.
        //
        // Параметры:
        //   password:
        //     Пароль
        //
        // Возврат:
        //     Результаты хэширования.
        //public HashData SaltAndHashPassword(string password)
        //{
        //    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, 32, 10000);
        //    return new HashData(rfc2898DeriveBytes.GetBytes(32), rfc2898DeriveBytes.Salt);
        //}

        //
        // Сводка:
        //     Проверка пароля на соовтетствие хэшу.
        //
        // Параметры:
        //   password:
        //     Пароль для проверки.
        //
        //   hashData:
        //     Хэшированные данные.
        //
        // Возврат:
        //     True если соответствуют, иначе false.
        //public bool ValidatePassword(string password, HashData hashData)
        //{
        //    byte[] bytes = new Rfc2898DeriveBytes(password, hashData.Salt, 10000).GetBytes(32);
        //    return IsSameByteArray(hashData.Hash, bytes);
        //}

        //
        // Сводка:
        //     Выполнить шифрование значения, используя захардкоженый секрет.
        //
        // Параметры:
        //   value:
        //     Значение для шифрования.
        //
        //   key:
        //     Ключ шифрования.
        //
        //   salt:
        //     Соль.
        //
        // Возврат:
        //     Шифрованное значение.
        public string EncryptWithSecret(string value, string key, string salt)
        {
            string result = value;
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {
                result = EncryptInternal(value, key, "#_$$995Ge" + salt);
            }

            return result;
        }

        //
        // Сводка:
        //     Выполнить дешифрование значения, используя захардкоженый секрет.
        //
        // Параметры:
        //   value:
        //     Значение для дешифрования.
        //
        //   key:
        //     Ключ шифрования.
        //
        //   salt:
        //     Соль.
        //
        // Возврат:
        //     Дешифрованное значение.
        public string DecryptWithSecret(string value, string key, string salt)
        {
            string result = value;
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {
                result = DecryptInternal(value, key, "#_$$995Ge" + salt);
            }

            return result;
        }

        //
        // Сводка:
        //     Шифрование ключа сессии.
        //
        // Параметры:
        //   plainSessionKey:
        //     Ключ сессии в расшифрованном.
        //
        //   masterKey:
        //     Ключ шифрования.
        //
        // Возврат:
        //     Зашифрованный ключ.
        public byte[] EncryptSessionKey(byte[] plainSessionKey, byte[] masterKey)
        {
            using RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Padding = PaddingMode.None;
            rijndaelManaged.Mode = CipherMode.ECB;
            rijndaelManaged.Key = masterKey;
            using ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
            return cryptoTransform.TransformFinalBlock(plainSessionKey, 0, plainSessionKey.Length);
        }

        //
        // Сводка:
        //     Дешифровка ключа сессии.
        //
        // Параметры:
        //   encryptedSessionKey:
        //     Зашифрованный ключ сессии.
        //
        //   masterKey:
        //     Ключ шифрования.
        //
        // Возврат:
        //     Расшифрованный ключ.
        public byte[] DecryptSessionKey(byte[] encryptedSessionKey, byte[] masterKey)
        {
            using RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Padding = PaddingMode.None;
            rijndaelManaged.Mode = CipherMode.ECB;
            rijndaelManaged.Key = masterKey;
            using ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
            return cryptoTransform.TransformFinalBlock(encryptedSessionKey, 0, encryptedSessionKey.Length);
        }

        //
        // Сводка:
        //     Выполнить шифрование.
        //
        // Параметры:
        //   key:
        //     Ключ шифрования.
        //
        //   IV:
        //     Инициализирующий вектор.
        //
        //   data:
        //     Даныне для шифрования.
        //
        // Возврат:
        //     Зашифрованные данные.
        public byte[] Encrypt(byte[] key, byte[] IV, string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            using RijndaelManaged rijndaelManaged = new RijndaelManaged();
            using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(key, IV);
            using MemoryStream memoryStream = new MemoryStream();
            using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            return memoryStream.ToArray();
        }

        //
        // Сводка:
        //     Выполнить дешифровку.
        //
        // Параметры:
        //   key:
        //     Ключ шифрования.
        //
        //   IV:
        //     Инициализирующий вектор.
        //
        //   data:
        //     Даныне для дешифровки.
        //
        // Возврат:
        //     Дешифрованные данные.
        public string Decrypt(byte[] key, byte[] IV, byte[] data)
        {
            using RijndaelManaged rijndaelManaged = new RijndaelManaged();
            using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(key, IV);
            using MemoryStream memoryStream = new MemoryStream();
            using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            byte[] bytes = memoryStream.ToArray();
            return Encoding.UTF8.GetString(bytes);
        }

        //
        // Сводка:
        //     Подписать данные.
        //
        // Параметры:
        //   key:
        //     Ключ подписи.
        //
        //   data:
        //     Данные для подписи.
        //
        // Возврат:
        //     Подпись данных.
        public byte[] CreateMac(byte[] key, string data)
        {
            using HMACSHA256 hMACSHA = new HMACSHA256(key);
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            return hMACSHA.ComputeHash(bytes);
        }

        //
        // Сводка:
        //     Проверка подписи данных.
        //
        // Параметры:
        //   key:
        //     Ключ подписи.
        //
        //   storedMac:
        //     Подписанные данные.
        //
        //   data:
        //     Данные.
        //
        // Возврат:
        //     true если подпись верна, иначе false
        public bool ValidateMac(byte[] key, byte[] storedMac, string data)
        {
            byte[] b = CreateMac(key, data);
            return IsSameByteArray(storedMac, b);
        }

        //
        // Сводка:
        //     Создать ключ нужного типа.
        //
        // Параметры:
        //   keyType:
        //     Тип ключа.
        //
        // Возврат:
        //     Ключ.
        //public byte[] GenerateKey(KeyType keyType)
        //{
        //    byte[] array = new byte[_keySizes[keyType]];
        //    using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
        //    rNGCryptoServiceProvider.GetBytes(array);
        //    return array;
        //}

        private static bool IsSameByteArray(byte[] a, byte[] b)
        {
            bool result = false;
            if (a.Length == b.Length)
            {
                int i;
                for (i = 0; i < a.Length && a[i] == b[i]; i++)
                {
                }

                result = i == a.Length;
            }

            return result;
        }

        private static string EncryptInternal(string input, string key, string salt)
        {
            return Convert.ToBase64String(EncryptBytes(Encoding.UTF8.GetBytes(input), key, salt));
        }

        private static byte[] EncryptBytes(byte[] input, string key, string salt)
        {
            using AesManaged aesManaged = new AesManaged();
            using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(key, Encoding.UTF8.GetBytes(salt));
            aesManaged.Key = passwordDeriveBytes.GetBytes(aesManaged.KeySize / 8);
            aesManaged.IV = passwordDeriveBytes.GetBytes(aesManaged.BlockSize / 8);
            using MemoryStream memoryStream = new MemoryStream();
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesManaged.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(input, 0, input.Length);
                cryptoStream.Close();
            }

            return memoryStream.ToArray();
        }

        private static string DecryptInternal(string input, string key, string salt)
        {
            byte[] bytes = DecryptBytes(Convert.FromBase64String(input), key, salt);
            return Encoding.UTF8.GetString(bytes);
        }

        private static byte[] DecryptBytes(byte[] input, string key, string salt)
        {
            using AesManaged aesManaged = new AesManaged();
            using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(key, Encoding.UTF8.GetBytes(salt));
            aesManaged.Key = passwordDeriveBytes.GetBytes(aesManaged.KeySize / 8);
            aesManaged.IV = passwordDeriveBytes.GetBytes(aesManaged.BlockSize / 8);
            using MemoryStream memoryStream = new MemoryStream();
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesManaged.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(input, 0, input.Length);
                cryptoStream.Close();
            }

            return memoryStream.ToArray();
        }
    }
}
