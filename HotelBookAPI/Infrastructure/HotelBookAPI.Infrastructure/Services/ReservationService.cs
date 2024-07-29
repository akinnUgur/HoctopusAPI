using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Booking.SetReservationInfo;
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
    public class ReservationService : BaseHTTPService, IReservationService
    {
        public ReservationService(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<SetReservationInfoResponse> SetReservationInfoAsync(SetReservationInfoRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.SetReservationInfo), cancellationToken);
            return JsonConvert.DeserializeObject<SetReservationInfoResponse>(response);
        }
    }
}
