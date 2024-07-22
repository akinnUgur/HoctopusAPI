using HotelBookAPI.Application.BusinessModels;

using HotelBookAPI.Application.Features.PriceSearch;
using HotelBookAPI.Application.Features.PriceSearch.HotelSearch;
using HotelBookAPI.Application.Features.PriceSearch.LocationSearch;
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
    public class PriceSearchService : BaseHTTPService, IPriceSearchService
    {
        public PriceSearchService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<PriceSearchResponse> HotelBasedSearchAsync(HotelBasedSearchRequest request, CancellationToken cancellationToken)
        {

            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.PriceSearch), cancellationToken);
            return JsonConvert.DeserializeObject<PriceSearchResponse>(response);
        }

        public async Task<PriceSearchResponse> LocationBasedSearchAsync(LocationBasedSearchRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.PriceSearch), cancellationToken);
            return JsonConvert.DeserializeObject<PriceSearchResponse>(response);
        }


    }
}
