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
    public class AutoCompleteService : BaseHTTPService, IAutoCompleteService
    {
   

        public AutoCompleteService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService)  :base(httpClientSettings, httpClientFactory, tokenCacheService) { }
        


        public async Task<AutoCompleteResponseDTO> GetAutoCompleteDataAsync(AutoCompleteRequestDTO request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.AutoComplete), cancellationToken);
            return JsonConvert.DeserializeObject<AutoCompleteResponseDTO>(response);
      
        }
    }
}
