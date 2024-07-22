using HotelBookAPI.Application.Features.PriceSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.OfferClasses
{
    public class Offer
    {
        public int Night { get; set; }
        public bool IsAvailable { get; set; }
        public int Availability { get; set; }

        public List<Room>? Rooms { get; set; }
        public bool IsRefundable { get; set; }

        public string? ExpiresOn { get; set; }
        public string? OfferId { get; set; }
        public string? CheckIn { get; set; }

        public Price? Price { get; set; }
    }
}
