using System.Web;

namespace SSO.Api.Extensions;

/// <summary>
/// Методы расширения для <see cref="Uri"/>.
/// </summary>
public static class UriExtensions
{
    /// <summary>
    /// Добавить параметр запроса.
    /// </summary>
    /// <param name="uri">Uri-код.</param>
    /// <param name="name">Название параметра.</param>
    /// <param name="value">Значение параметра.</param>
    public static void AddQueryParameter(ref Uri uri, string name, string value)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value)) return;

        AddQueryParameters(ref uri, new Dictionary<string, string> { { name, value } });
    }

    /// <summary>
    /// Добавить параметры запроса.
    /// </summary>
    /// <param name="uri">Uri-код.</param>
    /// <param name="parameters">Словарь параметров, где ключ - название параметра, а значение - значение параметра.</param>
    public static void AddQueryParameters(ref Uri uri, IDictionary<string, string> parameters)
    {
        if (parameters is null || !parameters.Any()) return;

        var uriBuilder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(uriBuilder.Query);

        foreach (var parameter in parameters)
            if (!string.IsNullOrEmpty(parameter.Key) && !string.IsNullOrEmpty(parameter.Key))
                query[parameter.Key] = parameter.Value;

        uriBuilder.Query = query.ToString();
        uri = uriBuilder.Uri;
    }
}