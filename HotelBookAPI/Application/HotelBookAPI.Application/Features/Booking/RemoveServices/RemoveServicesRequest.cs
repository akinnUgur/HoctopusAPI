
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.RemoveServices
{
    public class RemoveServicesRequest : IRequest<RemoveServicesResponse>
    {
        public required string TransactionId { get; set; }

        public required List<string> Services { get; set; }

        public required string Currency { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en_US";
    }
}
