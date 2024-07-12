using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.PriceSearch
{
    public class HotelBasedSearchRequestDTO : GenericPriceSearchRequestDTO
    {

        public bool CheckAllotment { get; set; }
        public bool CheckStopSale { get; set; }
        public bool GetOnlyDiscountedPrice { get; set; }
        public bool GetOnlyBestOffers { get; set; }
        public int ProductType { get; set; }
        public List<string> Products { get; set; }
        public List<RoomCriteria> RoomCriteria { get; set; }
        public string Nationality { get; set; }
        public string CheckIn { get; set; }
        public int Night { get; set; }
        public string Currency { get; set; }
        public string Culture { get; set; }





    }
}
