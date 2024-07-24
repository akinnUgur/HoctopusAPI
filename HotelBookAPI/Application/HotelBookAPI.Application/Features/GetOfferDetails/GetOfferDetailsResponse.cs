
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelDatas;
using HotelBookAPI.Application.DTOs.Common.OfferClasses;
using HotelBookAPI.Application.Features.PriceSearch;
using HotelBookAPI.Application.Features.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOfferDetails
{
    public class GetOfferDetailsResponse
    {
        public Header Header{ get; set; }
        public OfferDetailsBody? Body { get; set; }
    }
    public class OfferDetailsBody
    {
        public List<OfferDetails> OfferDetails { get; set; }
    }

}

