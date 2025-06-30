namespace SSO.Api.Dto.ResponseMessage;

/// <summary>
/// Базовое сообщение ответа.
/// </summary>
public class BaseResponseMessage
{
    /// <summary>
    /// Конструктор <see cref="BaseResponseMessage"/>.
    /// </summary>
    public BaseResponseMessage()
    {
    }

    /// <summary>
    /// Конструктор <see cref="BaseResponseMessage"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    protected BaseResponseMessage(int statusCode)
    {
        StatusCode = statusCode;
    }

    /// <summary>
    /// Конструктор <see cref="BaseResponseMessage"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    /// <param name="description">Описание ответа.</param>
    protected BaseResponseMessage(int statusCode, string description)
    {
        (StatusCode, Description) = (statusCode, description);
    }

    /// <summary>
    /// Http-код ответа.
    /// </summary>
    public int StatusCode { get; private set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; private set; }

    /// <summary>
    /// Передать Http-код.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    public void SetStatusCode(int statusCode)
        => StatusCode = statusCode;

    /// <summary>
    /// Передать описание.
    /// </summary>
    /// <param name="description">Описание.</param>
    public void SetDescription(string description)
        => Description = description;
}