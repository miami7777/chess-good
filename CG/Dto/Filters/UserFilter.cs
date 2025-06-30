namespace CG.Dto.Filters;

/// <summary>
/// Фильтр пользователь.
/// </summary>
public class UserFilter
{
    /// <summary>
    /// Идентификаторы пользователей.
    /// </summary>
    public IEnumerable<int>? Ids { get; set; }

    /// <summary>
    /// Номера телефонов.
    /// </summary>
    public IEnumerable<string>? PhoneNumbers { get; set; }
}