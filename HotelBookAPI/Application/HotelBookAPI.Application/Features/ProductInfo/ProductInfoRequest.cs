using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.ProductInfo
{
    public class ProductInfoRequest : IRequest<ProductInfoResponse>
    {
        public int ProductType { get; set; } = 2;
        public int OwnerProvider { get; set; } = 2;
        public string Product { get; set; }
        public string Culture { get; set; }

    }
}
