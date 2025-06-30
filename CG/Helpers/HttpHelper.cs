using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using CG.Interfaces;
using Newtonsoft.Json.Serialization;
using Azure.Core;
using Duende.IdentityModel.Client;

namespace CG.Helpers;

public class HttpHelper : IHttpHelper
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpHelper(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<HttpResponseMessage> SendGetAsync(string requestUri,string accessToken = null, string httpClient = "LichessClient")
    {
        using (var client = _httpClientFactory.CreateClient(httpClient))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
            if (!string.IsNullOrEmpty(accessToken))
            {
                client.SetBearerToken(accessToken);
            }
            return await client.SendAsync(requestMessage);
        }
    }
    public static async Task<T?> ParseHttpJsonResponseMessage<T>(HttpResponseMessage response, NamingStrategy? namingStrategy = null)
        where T : class
    {
        var contractResolver = new DefaultContractResolver
        {
            NamingStrategy = namingStrategy ?? new CamelCaseNamingStrategy()
        };

        var settings = new JsonSerializerSettings
        {
            ContractResolver = contractResolver,
            Formatting = Formatting.Indented
        };

        var responseString = await response.Content.ReadAsStringAsync();
        var message = JsonConvert.DeserializeObject<T>(responseString, settings);

        return message;
    }
    public async Task<T> ParseHttpResponseMessage<T>(HttpResponseMessage response)
    {
        var message = new object();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var responseString = await response.Content.ReadAsStringAsync();
        message = JsonSerializer.Deserialize<T>(responseString, options);

        return (T)message;
    }

    public async Task<HttpResponseMessage> SendPostAsync<T>(string uri, T requestData,string? accessToken,
        string httpClient = "LichessClient")
    {        
        using (var client = _httpClientFactory.CreateClient(httpClient))
        {
            if (!string.IsNullOrEmpty(accessToken))
            {
                client.SetBearerToken(accessToken);
            }

            return await client.PostAsJsonAsync(uri, requestData);
        }
    }
    public async Task<HttpResponseMessage> SendPostAuthAsync(string uri, string requestData,
        string httpClient = "LichessClient")
    {        
        using (var client = _httpClientFactory.CreateClient(httpClient))
        {
            client.DefaultRequestHeaders
        .Accept
        .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = new StringContent(requestData,
                                                Encoding.UTF8,
                                                "application/json");//CONTENT-TYPE header

           var res = await  client.SendAsync(request)
                  .ContinueWith(responseTask =>
                  {
                      Console.WriteLine("Response: {0}", responseTask.Result);
                      return responseTask.Result;
                  });
            
            return res;
        }
    }
    public async Task<HttpResponseMessage> SendPostLoginAsync<T>(string uri, T requestData)
    {
        using var client = _httpClientFactory.CreateClient("SsoClient");
        SetBearer(client, requestData);
        return await client.PostAsJsonAsync(uri, requestData);
    }

    public async Task<T> GetRequestAsync<T>(string clientName, string requestUri, string? accessToken = "lip_KWx5SUlBfYC5vnodLb9S")
        where T : class
    {
        accessToken = "lip_KWx5SUlBfYC5vnodLb9S";
        using var client = _httpClientFactory.CreateClient(clientName);
        if (!string.IsNullOrEmpty(accessToken))
        {
            client.SetBearerToken(accessToken);
        }
        var response = await client.GetAsync(requestUri);

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException(response.ReasonPhrase, null, response.StatusCode);

        return await ParseHttpResponseMessage<T>(response);
    }

    public async Task<List<T>> ParseHttpResponseMessageForList<T>(HttpResponseMessage response)
    {
        var message = new object();
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            message = JsonSerializer.Deserialize<List<T>>(responseString);
        }

        if (message is null)
            return new List<T>();
        return (List<T>)message;
    }

    

    public async Task<HttpResponseMessage> SendPutAsync<T>(string uri, T requestData, string httpClient = "LichessClient")
    {
        using var client = _httpClientFactory.CreateClient(httpClient);
        return await client.PutAsJsonAsync(uri, requestData);
    }

    public void SetBearer<T>(HttpClient client, T requestBody)
    {
        var accessToken = requestBody.GetType().GetProperty("AccessToken");
        if (accessToken != null && requestBody.GetType().GetProperty("AccessToken").GetValue(requestBody) != null)
        {
            client.SetBearerToken(requestBody.GetType().GetProperty("AccessToken").GetValue(requestBody).ToString());
        }
    }
}