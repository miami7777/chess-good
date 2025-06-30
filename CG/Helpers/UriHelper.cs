namespace CG.Helpers;

/// <summary>
/// Url помошник.
/// </summary>
public static class UriHelper
{
    /// <summary>
    /// Получить базовый url.
    /// </summary>
    /// <returns>URI (scheme://host + pathBase)</returns>
    public static string GetBaseUri(IHttpContextAccessor httpContextAccessor)
    {
        var currentContext = httpContextAccessor.HttpContext;
        var request = currentContext?.Request;
        var host = request?.Host.ToUriComponent();
        var pathBase = request?.PathBase.ToUriComponent();
        return $"https://{host}{pathBase}";
    }
}