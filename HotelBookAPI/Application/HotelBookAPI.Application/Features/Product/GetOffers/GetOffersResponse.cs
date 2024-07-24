using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.OfferClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.GetOffers
{
    public class GetOffersResponse
    {
        public required Header Header { get; set; }
        public GetOffersBody? Body { get; set; }
    }

    public class GetOffersBody
    {
        public required string ProductId { get; set; }

        [JsonProperty("information.total")]
        public int Total { get; set; }
        public required List<Offer> Offers { get; set; }
    }


}
