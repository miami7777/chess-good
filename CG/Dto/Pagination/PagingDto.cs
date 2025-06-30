using System.ComponentModel.DataAnnotations;

namespace SSO.Api.Dto.Pagination;

/// <summary>
/// DTO для указания постраничной навигации.
/// </summary>
public class PagingDto
{
    /// <summary>
    /// Столбец для сортировки, по умолчанию "Id" (имя столбца нужно указать в CamelCase). 
    /// </summary>
    [RegularExpression(@"([A-Z][a-z0-9]+)((\d)|([A-Z0-9][a-z0-9]+))*([A-Z])?",
        ErrorMessage = "Value for {0} must be in сamelCase.")]
    public string? SortColumn { get; set; } = "Id";

    /// <summary>
    /// Направление сортировки.
    /// </summary>
    [RegularExpression(@"asc|desc",
        ErrorMessage = "Value for {0} must be 'asc' or 'desc'.")]
    public string? SortDirection { get; set; } = "asc";

    /// <summary>
    /// Номер страницы.
    /// </summary>
    [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int Page { get; set; } = 1;

    /// <summary>
    /// Количество элементов на странице, по умолчанию 30.
    /// </summary>
    [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int PerPage { get; set; } = 30;

    /// <summary>
    /// Количество элементов, которое нужно пропустить.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int? Skip { get; set; }
}