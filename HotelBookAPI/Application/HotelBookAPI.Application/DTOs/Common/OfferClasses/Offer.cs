
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.OfferClasses
{
    public class Offer
    {
        public required int Night { get; set; }
        public required bool IsAvailable { get; set; }
        public required int Availability { get; set; }

        public required List<Room> Rooms { get; set; }
        public required bool IsRefundable { get; set; }

        public required string ExpiresOn { get; set; }
        public required string OfferId { get; set; }
        public string? CheckIn { get; set; }

        public required Price Price { get; set; }
    }
}
