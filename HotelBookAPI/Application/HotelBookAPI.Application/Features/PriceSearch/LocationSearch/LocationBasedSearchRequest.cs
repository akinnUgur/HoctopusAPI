using HotelBookAPI.Application.DTOs.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.PriceSearch.LocationSearch
{
    public class LocationBasedSearchRequest : IRequest<PriceSearchResponse>
    {
        public List<ArrivalLocation> ArrivalLocations { get; set; }
        public List<RoomCriteria> RoomCriteria { get; set; }

        public string Nationality { get; set; }

        public string CheckIn { get; set; }
        public int Night { get; set; }
        public string Currency { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";

    }


}
