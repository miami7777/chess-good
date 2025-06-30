using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSO.Api.Dto.Pagination;
using SSO.Api.Dto.ResponseMessage;

namespace CG.Builders;

/// <summary>
/// Строитель ответов.
/// </summary>
public class ResponseBuilder
{
    private readonly IMapper _mapper;
    private BaseResponseMessage _response = new();

    /// <summary>
    /// Конструктор <see cref="ResponseBuilder"/>.
    /// </summary>
    /// <param name="mapper"></param>
    public ResponseBuilder(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Передать описание.
    /// </summary>
    /// <param name="description">Описание.</param>
    public ResponseBuilder SetDescription(string description)
    {
        _response.SetDescription(description);
        return this;
    }

    /// <summary>
    /// Передать данные.
    /// </summary>
    /// <param name="data">DTO возвращаемой сущности.</param>
    public ResponseBuilder SetData<T>(T data)
    {
        if (_response is not BaseResponseMessage)
        {
            ((ResponseMessage<object>)_response).SetData(data!);
            return this;
        }

        var responseWithData = _mapper.Map<ResponseMessage<object>>(_response);
        responseWithData.SetData(data!);
        _response = responseWithData;
        return this;
    }

    /// <summary>
    /// Передать постраничную навигацию.
    /// </summary>
    /// <param name="paging">Постраничная навигация.</param>
    public ResponseBuilder SetPaging(ResponsePagingDto paging)
    {
        if (_response is BaseResponseMessage or ResponseMessage<object>)
        {
            var responseWithPaging = _mapper.Map<ResponseMessageWithPaging<object>>(_response);
            responseWithPaging.SetPaging(paging);
            _response = responseWithPaging;
            return this;
        }

        ((ResponseMessageWithPaging<object>)_response).SetPaging(paging);
        return this;
    }

    /// <summary>
    /// Собрать ответ.
    /// </summary>
    /// <param name="statusCode">Http код ответа.</param>
    /// <returns>Рузультат ответа.</returns>
    public ObjectResult Build(int statusCode)
    {
        _response.SetStatusCode(statusCode);
        return new ObjectResult(_response) { StatusCode = statusCode };
    }
}