using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.PriceSearch
{
    public class LocationBasedSearchRequestDTO : GenericPriceSearchRequestDTO
    {
        public bool CheckAllotment { get; set; }
        public bool CheckStopSale { get; set; }
        public bool GetOnlyDiscountedPrice { get; set; }
        public bool GetOnlyBestOffers { get; set; }
        public int ProductType { get; set; }
        public List<ArrivalLocation> ArrivalLocations { get; set; }
        public List<RoomCriteria> RoomCriteria { get; set; }
        public string Nationality { get; set; }
        public string CheckIn { get; set; }
        public int Night { get; set; }
        public string Currency { get; set; }
        public string Culture { get; set; }

        public PagingOption PagingOption { get; set; }
    } 
    public class PagingOption
    {
        public int CurrentPage { get; set; } = 1;
        public int PageRowCount { get; set; } = 0;

    }
}
