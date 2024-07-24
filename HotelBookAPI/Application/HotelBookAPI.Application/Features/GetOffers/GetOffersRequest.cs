using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOffers
{
    public class GetOffersRequest : IRequest<GetOffersResponse>
    {
        public required string SearchId{ get; set; }
        public required string OfferId { get; set; }

        [JsonIgnore]
        public int ProductType { get; set; } = 2;

        public required string ProductId { get; set; }
        public required string Currency { get; set; }
        [JsonIgnore]
        public string Culture { get; set; } = "en-US";

        [JsonIgnore]
        public bool GetRoomInfo { get; set; } = true;
      

    }
}
