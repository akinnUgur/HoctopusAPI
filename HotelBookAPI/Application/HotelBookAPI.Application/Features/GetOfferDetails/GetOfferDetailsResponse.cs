using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.DTOs.Common;
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
    public class OfferDetails
    {
        public string ExpiresOn { get; set; }
        public string OfferId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public Price Price { get; set; }
        public List<ProductInfoHotel> Hotels{ get; set; }
    }
}

