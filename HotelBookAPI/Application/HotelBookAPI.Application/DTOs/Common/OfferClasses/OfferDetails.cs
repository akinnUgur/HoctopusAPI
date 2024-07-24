using HotelBookAPI.Application.DTOs.Common.HotelDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.OfferClasses
{
    public class OfferDetails
    {
        public required string ExpiresOn { get; set; }
        public required string OfferId { get; set; }
        public required string CheckIn { get; set; }
        public required string CheckOut { get; set; }
        public required Price Price { get; set; }
        public required List<HotelInfo> Hotels { get; set; }
    }
}
