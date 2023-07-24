using Microsoft.Extensions.Configuration;
using SessionTokenApi.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SessionTokenApi
{
    public class SessionTokenService
    {
        private readonly IConfiguration _configuration;
        public SessionTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GetSessionToken(SessionTokenRequest request)
        {
            string url = _configuration.GetValue<string>("host_url");
            string apiKey = _configuration.GetValue<string>("apiKey");

            // Prepare the request data as a JSON string
            string requestData = JsonSerializer.Serialize(request);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("ApiKey", apiKey);
                var content = new StringContent(requestData, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            return string.Empty;
        }
    }
}
