using HotelBookAPI.Application.DTOs.PriceSearch;
using HotelBookAPI.Application.Features.PriceSearch;
using HotelBookAPI.Application.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Services
{
    public class PriceSearchService : IPriceSearchService
    {
        private readonly HttpClientSettings _httpClientSettings;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly TokenCacheService _tokenCacheService;

        public PriceSearchService(TokenCacheService tokenCacheService, IHttpClientFactory httpClientFactory, HttpClientSettings httpClientSettings)
        {
            _tokenCacheService = tokenCacheService;
            _httpClientFactory = httpClientFactory;
            _httpClientSettings = httpClientSettings;
        }

        public async Task<string> GenericPriceSearchAsync(GenericPriceSearchRequestDTO request, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient(_httpClientSettings.Name);

            var bearerToken = await _tokenCacheService.GetOrCreateAccessTokenAsync(cancellationToken);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var jsonRequest = JsonConvert.SerializeObject(request);

            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{_httpClientSettings.BaseAddress}productservice/pricesearch", content, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Request failed with status code: " + response.StatusCode);
            }

            var jsonResponse = await response.Content.ReadAsStringAsync(cancellationToken);

            return jsonResponse;


        }

        public async Task<PriceSearchResponse> HotelBasedSearchAsync(HotelBasedSearchRequestDTO request, CancellationToken cancellationToken)
        {

            var response = await GenericPriceSearchAsync(request, cancellationToken);

            return JsonConvert.DeserializeObject<PriceSearchResponse>(response);
        }

        public async Task<PriceSearchResponse> LocationBasedSearchAsync(LocationBasedSearchRequestDTO request, CancellationToken cancellationToken)
        {
            var response = await GenericPriceSearchAsync(request, cancellationToken);

            return JsonConvert.DeserializeObject<PriceSearchResponse>(response);

        }


    }
}
