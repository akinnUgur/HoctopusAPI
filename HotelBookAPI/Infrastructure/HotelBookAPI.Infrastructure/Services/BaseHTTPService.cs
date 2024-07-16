using HotelBookAPI.Infrastructure.Settings;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace HotelBookAPI.Infrastructure.Services
{
    public class BaseHTTPService
    {
        private readonly HttpClientSettings _httpClientSettings;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly TokenCacheService _tokenCacheService;

        public BaseHTTPService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService)
        {
            _httpClientSettings = httpClientSettings;
            _httpClientFactory = httpClientFactory;
            _tokenCacheService = tokenCacheService;
        }

        protected async Task<string> PostAsync<TRequest>(TRequest request, string endpoint, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient(_httpClientSettings.Name);

            var bearerToken = await _tokenCacheService.GetOrCreateAccessTokenAsync(cancellationToken);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{_httpClientSettings.BaseAddress}{endpoint}", content, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Request failed with status code: " + response.StatusCode);
            }

            return await response.Content.ReadAsStringAsync(cancellationToken);

        }
    }
}
