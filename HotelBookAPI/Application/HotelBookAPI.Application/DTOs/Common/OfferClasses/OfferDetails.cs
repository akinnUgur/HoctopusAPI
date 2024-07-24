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
        public string ExpiresOn { get; set; }
        public string OfferId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public Price Price { get; set; }
        public List<HotelInfo> Hotels { get; set; }
    }
}
