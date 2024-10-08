﻿using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Booking.GetReservationDetails;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Application.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Services
{
    public class GetReservationDetailsServices : BaseHTTPService, IGetReservationDetailsService
    {
        public GetReservationDetailsServices(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<GetReservationDetailsResponse> GetReservationDetailsAsync(GetReservationDetailsRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.GetReservationDetails), cancellationToken);
            return JsonConvert.DeserializeObject<GetReservationDetailsResponse>(response);
        }
    }
}
