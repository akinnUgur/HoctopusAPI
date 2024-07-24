using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.OfferClasses;

namespace HotelBookAPI.Application.Features.Product.GetOfferDetails
{
    public class GetOfferDetailsResponse
    {
        public required Header Header { get; set; }
        public OfferDetailsBody? Body { get; set; }
    }
    public class OfferDetailsBody
    {
        public required List<OfferDetails> OfferDetails { get; set; }
    }

}

