using SSO.Api.Dto.Pagination;

namespace SSO.Api.Dto.ResponseMessage;

/// <summary>
/// Списочное ответное сообщение.
/// </summary>
/// <typeparam name="T">DTO возвращаемой сущности.</typeparam>
public class ResponseMessageWithPaging<T> : ResponseMessage<T> where T : class
{
    /// <summary>
    /// Конструктор <see cref="ResponseMessageWithPaging"/>.
    /// </summary>
    public ResponseMessageWithPaging()
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessageWithPaging"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    public ResponseMessageWithPaging(int statusCode) : base(statusCode)
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessageWithPaging"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    /// <param name="description">Описание ответа.</param>
    public ResponseMessageWithPaging(int statusCode, string description) : base(statusCode, description)
    {
    }

    /// <summary>
    /// Конструктор <see cref="ResponseMessageWithPaging"/>.
    /// </summary>
    /// <param name="statusCode">Http-код.</param>
    /// <param name="description">Описание ответа.</param>
    /// <param name="data">Коллекция DTO возвращаемой сущности.</param>
    /// <param name="paging">Постраничная навигация.</param>
    public ResponseMessageWithPaging(int statusCode, string description, T data, ResponsePagingDto? paging = null) :
        base(statusCode, description, data)
    {
        if (paging is not null)
            Paging = paging;
    }

    /// <summary>
    /// Ответная постраничная навигация.
    /// </summary>
    public ResponsePagingDto? Paging { get; private set; }

    /// <summary>
    /// Передать постраничную навигацию.
    /// </summary>
    /// <param name="paging">Постраничная навигация.</param>
    public void SetPaging(ResponsePagingDto paging)
        => Paging = paging;
}