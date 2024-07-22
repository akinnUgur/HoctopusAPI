using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.CommitTransaction;
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
    public class TransactionService : BaseHTTPService, ITransactionService
    {
        public TransactionService(HttpClientSettings httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.CommitTransaction), cancellationToken);
            return JsonConvert.DeserializeObject<CommitTransactionResponse>(response);
        }
    }
}
