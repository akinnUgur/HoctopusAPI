using HotelBookAPI.Application.DTOs.PriceSearch;
using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.PriceSearch;
using HotelBookAPI.Application.Features.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IAddServicesService
    {
        Task<AddServicesResponse> AddServicesAsync(AddServicesRequest request, CancellationToken cancellationToken);

    }
}
