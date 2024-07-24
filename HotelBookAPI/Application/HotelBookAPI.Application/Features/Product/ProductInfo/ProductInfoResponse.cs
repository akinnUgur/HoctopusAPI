using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelDatas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.ProductInfo
{
    public class ProductInfoResponse
    {

        public required Header Header { get; set; }
        public ProductInfoBody? Body { get; set; }
    }


    public class ProductInfoBody
    {
        public required HotelInfo Hotel { get; set; }
    }


}
