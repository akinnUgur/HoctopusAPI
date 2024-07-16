using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.ProductInfo
{
    public class ProductInfoHandler : CommonHandler, IRequestHandler<ProductInfoRequest, ProductInfoResponse>
    {
        public ProductInfoHandler(IMapper mapper) : base(mapper)
        {
        }

        public Task<ProductInfoResponse> Handle(ProductInfoRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
