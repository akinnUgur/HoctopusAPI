using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Product.FilterPriceSearch;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Application.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Services
{
    public class FilterPriceSearchService : BaseHTTPService, IFilterPriceSearchService
    {
        public FilterPriceSearchService(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<FilterPriceSeachResponse> FilterSearchAsync(FilterPriceSearchRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.FilterPriceSearch), cancellationToken);
            return JsonConvert.DeserializeObject<FilterPriceSeachResponse>(response);
        }
    }
}
