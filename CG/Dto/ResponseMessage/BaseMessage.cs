using System.Text.Json.Serialization;

namespace SSO.Api.Dto.ResponseMessage;

public class BaseMessage
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}