namespace SSO.Api.Dto.ResponseMessage;

/// <summary>
/// Ответное сообщение.
/// </summary>
/// <typeparam name="T">DTO возвращаемой сущности.</typeparam>
public class ResponseMessage<T> : BaseResponseMessage where T : class
{
    /// <summary>
    /// Конструктор <see cref="ResponseMessage"/>.
    /// </summary>
    public ResponseMessage()
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessage"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    public ResponseMessage(int statusCode) : base(statusCode)
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessage"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    /// <param name="description">Описание ответа.</param>
    public ResponseMessage(int statusCode, string description) : base(statusCode, description)
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessage"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    /// <param name="description">Описание ответа.</param>
    /// <param name="data">DTO возвращаемой сущности.</param>
    public ResponseMessage(int statusCode, string description, T data) : base(statusCode, description)
    {
        Data = data;
    }

    /// <summary>
    /// Данные.
    /// </summary>
    public T? Data { get; private set; }

    /// <summary>
    /// Передать данные.
    /// </summary>
    /// <param name="data">DTO возвращаемой сущности.</param>
    public void SetData(T data)
        => Data = data;
}