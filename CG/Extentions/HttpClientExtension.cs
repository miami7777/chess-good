using Microsoft.Net.Http.Headers;

namespace CG.Extentions
{
    public static class HttpClientExtension
    {
        public static void AddHttpClients(this IServiceCollection services, string serverUrl)
        {
            services.AddHttpClient("LichessClient", client =>
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            });
        }
    }
}
