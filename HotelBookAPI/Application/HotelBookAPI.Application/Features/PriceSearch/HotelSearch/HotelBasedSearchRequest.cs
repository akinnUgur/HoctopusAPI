using HotelBookAPI.Application.DTOs.Common;
using MediatR;
using System.Text.Json.Serialization;

namespace HotelBookAPI.Application.Features.PriceSearch.HotelSearch
{
    public class HotelBasedSearchRequest : IRequest<PriceSearchResponse>
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


        public required List<string> Products { get; set; }
        public required List<RoomCriteria> RoomCriteria { get; set; }
        public required string Nationality { get; set; }
        public required string CheckIn { get; set; }
        public required int Night { get; set; }
        public required string Currency { get; set; }

    }

}
