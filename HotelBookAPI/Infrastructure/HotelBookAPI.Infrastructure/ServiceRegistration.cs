using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Services;
using HotelBookAPI.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure
{
    public static class ServiceRegistration
    {

        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddMemoryCache();


            var httpClientSettings = configuration.GetSection("HttpClientSettings").Get<HttpClientSettings>();


            services.AddHttpClient(httpClientSettings.Name, client =>
            {
                client.BaseAddress = new Uri(httpClientSettings.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });


            services.AddSingleton(httpClientSettings);
            services.AddSingleton<TokenCacheService>();

            services.AddTransient<IAutoCompleteService, AutoCompleteService>();
            services.AddTransient<IPriceSearchService, PriceSearchService>();
            services.AddTransient<IProductInfoService, ProductInfoService>();
            services.AddTransient<IBeginTransactionService, BeginTransactionService>();
            services.AddTransient<IOfferService, OfferService>();



        }
    }
}
