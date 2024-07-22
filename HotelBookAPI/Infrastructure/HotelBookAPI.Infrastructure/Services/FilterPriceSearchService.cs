﻿using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using HotelBookAPI.Application.Features.FilterPriceSearch;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Settings;
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
        public FilterPriceSearchService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<FilterPriceSeachResponse> FilterSearchAsync(FilterPriceSearchRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.FilterPriceSearch), cancellationToken);
            return JsonConvert.DeserializeObject<FilterPriceSeachResponse>(response);
        }
    }
}
