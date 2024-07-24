using HotelBookAPI.Application.Features.Product.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IProductInfoService
    {
        Task<ProductInfoResponse> GetProductInfoAsync(ProductInfoRequest request, CancellationToken cancellationToken);
    } 
}
