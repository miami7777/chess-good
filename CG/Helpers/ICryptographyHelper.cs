using System.Drawing.Drawing2D;

namespace CG.Helpers
{
    public interface ICryptographyHelper
    {
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
        //HashData SaltAndHashPassword(string password);

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
        //bool ValidatePassword(string password, HashData hashData);

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
        string EncryptWithSecret(string value, string key, string salt);

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
        string DecryptWithSecret(string value, string key, string salt);

        //
        // Сводка:
        //     Шифрование ключа сессии.
        //
        // Параметры:
        //   sessionKey:
        //     Ключ сессии.
        //
        //   masterKey:
        //     Ключ шифрования.
        //
        // Возврат:
        //     Зашифрованный ключ.
        byte[] EncryptSessionKey(byte[] sessionKey, byte[] masterKey);

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
        byte[] DecryptSessionKey(byte[] encryptedSessionKey, byte[] masterKey);

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
        byte[] CreateMac(byte[] key, string data);

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
        bool ValidateMac(byte[] key, byte[] storedMac, string data);

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
        //byte[] GenerateKey(KeyType keyType);

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
        byte[] Encrypt(byte[] key, byte[] IV, string data);

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
        string Decrypt(byte[] key, byte[] IV, byte[] data);
    }
}
