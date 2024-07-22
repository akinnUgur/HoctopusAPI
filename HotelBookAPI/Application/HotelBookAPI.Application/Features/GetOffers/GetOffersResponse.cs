using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.OfferClasses;
using HotelBookAPI.Application.Features.PriceSearch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOffers
{
    public class GetOffersResponse
    {
        public Header Header { get; set; }
        public GetOffersBody? Body { get; set; }
    }

    public class GetOffersBody
    {
        public string ProductId { get; set; }

        [JsonProperty("information.total")]
        public int Total { get; set; }
        public List<Offer> Offers { get; set; }
    }
  

}
