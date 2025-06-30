namespace SSO.Api.Dto.ResponseMessage;

/// <summary>
/// Ответ об ошибках.
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// Ошибки.
    /// </summary>
    public IEnumerable<ErrorInFieldDto> Errors { get; set; }
}