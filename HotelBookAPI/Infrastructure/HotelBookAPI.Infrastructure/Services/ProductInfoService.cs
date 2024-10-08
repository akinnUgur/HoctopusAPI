﻿using HotelBookAPI.Application.BusinessModels;
using HotelBookAPI.Application.Features.Product.ProductInfo;
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
    public class ProductInfoService : BaseHTTPService, IProductInfoService
    {
        public ProductInfoService(IOptions<HttpClientSettings> httpClientSettings, IHttpClientFactory httpClientFactory, TokenCacheService tokenCacheService) : base(httpClientSettings, httpClientFactory, tokenCacheService)
        {
        }

        public async Task<ProductInfoResponse> GetProductInfoAsync(ProductInfoRequest request, CancellationToken cancellationToken)
        {
            var response = await PostAsync(request, EnumHelper.GetEnumDescription(TourVisioServices.ProductInfo), cancellationToken);
            return JsonConvert.DeserializeObject<ProductInfoResponse>(response);
        }
    }
}
