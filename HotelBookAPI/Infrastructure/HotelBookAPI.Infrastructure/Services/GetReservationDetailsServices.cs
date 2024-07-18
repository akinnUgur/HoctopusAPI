using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.GetReservationDetails;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Settings;
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
        public GetReservationDetailsServices(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<GetReservationDetailsResponse> GetReservationDetailsAsync(GetReservationDetailsRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.AddServices), cancellationToken);
            return JsonConvert.DeserializeObject<GetReservationDetailsResponse>(response);
        }
    }
}
