using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Services
{
    public class AutoCompleteService : IAutoCompleteService
    {
        private readonly HttpClientSettings _httpClientSettings;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly TokenCacheService _tokenCacheService;

        public AutoCompleteService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService)
        {

            _httpClientSettings = httpClientSettings;
            _httpClientFactory = httpClientFactory;
            _tokenCacheService = tokenCacheService;
        }


        public async Task<AutoCompleteResponseDTO> GetAutoCompleteDataAsync(AutoCompleteRequestDTO request, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient(_httpClientSettings.Name);

            var bearerToken = await _tokenCacheService.GetOrCreateAccessTokenAsync(cancellationToken);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);


            var jsonRequest = JsonConvert.SerializeObject(request);

            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{_httpClientSettings.BaseAddress}{EnumHelper.GetEnumDescription(TourVisioServices.AutoComplete)}", content, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Request failed with status code: " + response.StatusCode);
            }

            var jsonResponse = await response.Content.ReadAsStringAsync(cancellationToken);
            var autoCompleteResponse = JsonConvert.DeserializeObject<AutoCompleteResponseDTO>(jsonResponse);

            return autoCompleteResponse;
        }
    }
}
