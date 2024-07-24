using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.ProductInfo
{
    public class ProductInfoRequest : IRequest<ProductInfoResponse>
    {
        [JsonIgnore]
        public int ProductType { get; set; } = 2;

        [JsonIgnore]
        public int OwnerProvider { get; set; } = 2;
        public required string Product { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";

    }
}
