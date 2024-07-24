using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.Features.Product.PriceSearch;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.PriceSearch.LocationSearch
{
    public class LocationBasedSearchRequest : IRequest<PriceSearchResponse>
    {
        [JsonIgnore]
        public bool CheckAllotment { get; set; } = true;
        [JsonIgnore]
        public bool CheckStopSale { get; set; } = true;
        [JsonIgnore]
        public bool GetOnlyDiscountedPrice { get; set; } = false;
        [JsonIgnore]
        public bool GetOnlyBestOffers { get; set; } = true;
        [JsonIgnore]
        public int ProductType { get; set; } = 2;
        [JsonIgnore]
        public string Culture { get; set; } = "en-US";
        public required List<ArrivalLocation> ArrivalLocations { get; set; }
        public required List<RoomCriteria> RoomCriteria { get; set; }
        public required string Nationality { get; set; }
        public required string CheckIn { get; set; }
        public required int Night { get; set; }
        public required string Currency { get; set; }


        public required PagingOption PagingOption { get; set; }
    }
    public class PagingOption
    {
        public int CurrentPage { get; set; } = 1;
        public int PageRowCount { get; set; } = 0;

    }
}
