using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.AddServices
{
    public class AddServicesRequest : IRequest<AddServicesResponse>
    {
        public required string TransactionId { get; set; }

        public required List<AddServiceOffer> Offers { get; set; }

        public required string Currency { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";
    }
    public class AddServiceOffer
    {
        public required string OfferId { get; set; }

        public required List<string> Travellers { get; set; }
    }
}
