using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.ProductInfo
{
    public class ProductInfoHandler : CommonHandler, IRequestHandler<ProductInfoRequest, ProductInfoResponse>
    {
        private readonly IProductInfoService _productInfoService;
        public ProductInfoHandler(IMapper mapper, IProductInfoService productInfoService) : base(mapper)
        {
            _productInfoService = productInfoService;
        }

        public Task<ProductInfoResponse> Handle(ProductInfoRequest request, CancellationToken cancellationToken)
        {
            return _productInfoService.GetProductInfoAsync(request, cancellationToken);
        }
    }
}
