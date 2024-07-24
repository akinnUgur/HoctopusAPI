using MediatR;
using System.Text.Json.Serialization;


namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionRequest: IRequest<BeginTransactionResponse>
    {
        public required List<string> OfferIds { get; set; }

        public required string Currency { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";
    }
}
