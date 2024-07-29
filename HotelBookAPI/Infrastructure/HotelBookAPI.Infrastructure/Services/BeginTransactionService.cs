using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Application.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using HotelBookAPI.Application.BusinessModels;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace HotelBookAPI.Infrastructure.Services
{
    public class BeginTransactionService : BaseHTTPService, IBeginTransactionService
    {
        public BeginTransactionService(IOptions<HttpClientSettings> httpClientSettings,IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory,tokenCacheService){ }

        public async Task<BeginTransactionResponse> BeginTransactionWithOfferAsync(BeginTransactionRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.BeginTransaction), cancellationToken);
            return JsonConvert.DeserializeObject<BeginTransactionResponse>(response);
        }
    }
}
