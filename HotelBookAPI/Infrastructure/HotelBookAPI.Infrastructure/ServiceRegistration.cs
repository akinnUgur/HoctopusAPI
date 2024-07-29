using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Infrastructure.Services;
using HotelBookAPI.Application.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HotelBookAPI.API.Controllers;
using HotelBookAPI.Application.Settings;

namespace HotelBookAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        // var emailSettings = configuration.GetSection("EmailSettings").Get<EmailSettings>();
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddMemoryCache();


            var httpClientSettings = configuration.GetSection("HttpClientSettings").Get<HttpClientSettings>();
           


            //services.AddHttpClient(httpClientSettings.Name, client =>
            //{
            //    client.BaseAddress = new Uri(httpClientSettings.BaseAddress);
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //}
            //);

            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.Configure<HttpClientSettings>(configuration.GetSection("HttpClientSettings")).AddHttpClient(httpClientSettings.Name, client =>
            {
                client.BaseAddress = new Uri(httpClientSettings.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

           //services.AddSingleton(httpClientSettings);
            services.AddTransient<IEmailService, EmailService>();
            services.AddSingleton<TokenCacheService>();
            services.AddTransient<IAutoCompleteService, AutoCompleteService>();
            services.AddTransient<IPriceSearchService, PriceSearchService>();
            services.AddTransient<IProductInfoService, ProductInfoService>();
            services.AddTransient<IBeginTransactionService, BeginTransactionService>();
            services.AddTransient<IOfferService, OfferService>();
            services.AddTransient<IAddServicesService, AddServicesService>();
            services.AddTransient<IRemoveServicesService, RemoveServicesService>();
            services.AddTransient<IGetReservationDetailsService, GetReservationDetailsServices>();
            services.AddTransient<IFilterPriceSearchService, FilterPriceSearchService>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<ITransactionService,  TransactionService>();


        }
    }
}
