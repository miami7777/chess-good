namespace SSO.Api.Dto.Pagination;

/// <summary>
/// Ответная постраничная навигация.
/// </summary>
public class ResponsePagingDto
{
    /// <summary>
    /// Номер запрошенной страницы.
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// Количество элементов на странице.
    /// </summary>
    public int PerPage { get; set; }

    /// <summary>
    /// Номер последней страницы.
    /// </summary>
    public int LastPage => (int)Math.Ceiling((decimal)TotalItems / PerPage);

    /// <summary>
    /// Общее количество элементов.
    /// </summary>
    public long TotalItems { get; set; }
}