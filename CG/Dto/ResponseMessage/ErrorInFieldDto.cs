namespace SSO.Api.Dto.ResponseMessage;

/// <summary>
/// DTO ошибки в поле теза запроса.
/// </summary>
public class ErrorInFieldDto
{
    /// <summary>
    /// Имя поля.
    /// </summary>
    public string FieldName { get; set; }

    /// <summary>
    /// Сообщение.
    /// </summary>
    public string? Message { get; set; }
}