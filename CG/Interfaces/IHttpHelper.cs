namespace CG.Interfaces;

public interface IHttpHelper
{
    public Task<HttpResponseMessage> SendGetAsync(string requestUri,string access_token = null, string httpClient = "LichessClient");    
    public Task<T> ParseHttpResponseMessage<T>(HttpResponseMessage response);
    public Task<HttpResponseMessage> SendPostAsync<T>(string uri, T requestData, string httpClient = "LichessClient",string access_token = null);
    public Task<HttpResponseMessage> SendPostAuthAsync(string uri, string requestData, string httpClient = "LichessClient");
    public Task<HttpResponseMessage> SendPutAsync<T>(string uri, T requestData, string httpClient = "LichessClient");
    public Task<List<T>> ParseHttpResponseMessageForList<T>(HttpResponseMessage response);

    public Task<T> GetRequestAsync<T>(string clientName, string requestUri, string? accessToken = null) where T : class;


    #region SSO.Service
    
    public void SetBearer<T>(HttpClient client, T requestBody);

    #endregion
}