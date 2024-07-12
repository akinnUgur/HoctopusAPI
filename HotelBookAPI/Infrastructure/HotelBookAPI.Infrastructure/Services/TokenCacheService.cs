using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Caching.Memory;

namespace HotelBookAPI.Infrastructure.Services
{
    public class TokenCacheService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClientSettings _httpClientSettings;
        private readonly IMemoryCache _memoryCache;

        public TokenCacheService(IHttpClientFactory httpClientFactory, HttpClientSettings httpClientSettings, IMemoryCache memoryCache)
        {
            _httpClientFactory = httpClientFactory;
            _httpClientSettings = httpClientSettings;
            _memoryCache = memoryCache;
        }
        public async Task<string> GetOrCreateAccessTokenAsync(CancellationToken cancellationToken)
        {
            string cacheKey = "AccessToken";

            if (!_memoryCache.TryGetValue(cacheKey, out string accessToken))
            {
                accessToken = await RetrieveAccessTokenFromApi(cancellationToken);
                _memoryCache.Set(cacheKey, accessToken, TimeSpan.FromHours(5));
            }

            return accessToken;
        }

        private async Task<string> RetrieveAccessTokenFromApi(CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient(_httpClientSettings.Name);
            client.BaseAddress = new Uri($"{_httpClientSettings.BaseAddress}authenticationservice/login");

            var requestBody = new
            {
                Agency = _httpClientSettings.Agency,
                User = _httpClientSettings.User,
                Password = _httpClientSettings.Password
            };
            var jsonContent = new StringContent(
           JsonConvert.SerializeObject(requestBody),
           Encoding.UTF8,
           "application/json"
       );

            var response = await client.PostAsync($"{_httpClientSettings.BaseAddress}authenticationservice/login", jsonContent, cancellationToken);



            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to retrieve access token: {response.StatusCode}");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync(cancellationToken);
            var tokenObject = JObject.Parse(jsonResponse);
            var bearerToken = tokenObject["body"]["token"].ToString();

            return bearerToken;
        }
    }
}
