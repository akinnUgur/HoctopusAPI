using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Booking.RemoveServices;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Services;
using HotelBookAPI.Application.Settings;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace HotelBookAPI.API.Controllers
{
    public class RemoveServicesService : BaseHTTPService, IRemoveServicesService
    {
        public RemoveServicesService(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<RemoveServicesResponse> RemoveServicesAsync(RemoveServicesRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.RemoveServices), cancellationToken);
            return JsonConvert.DeserializeObject<RemoveServicesResponse>(response);
        }
    }
}
