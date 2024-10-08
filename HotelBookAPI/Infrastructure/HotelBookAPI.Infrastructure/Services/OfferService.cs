﻿using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Product.GetOfferDetails;
using HotelBookAPI.Application.Features.Product.GetOffers;
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
    public class OfferService : BaseHTTPService, IOfferService
    {
        public OfferService(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<GetOffersResponse> GetOffersAsync(GetOffersRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.GetOffers), cancellationToken);
            return JsonConvert.DeserializeObject<GetOffersResponse>(response);
        }

        public async Task<GetOfferDetailsResponse> GetOfferDetailsAsync(GetOfferDetailsRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.GetOfferDetails), cancellationToken);
            return JsonConvert.DeserializeObject<GetOfferDetailsResponse>(response);
        }

   
    }
}
