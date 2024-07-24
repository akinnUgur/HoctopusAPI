using HotelBookAPI.Application.DTOs.Common;
using MediatR;



namespace HotelBookAPI.Application.Features.Booking.SetReservationInfo
{
    public class SetReservationInfoRequest : IRequest<SetReservationInfoResponse>
    {
        public required string TransactionId { get; set; }
        public required List<TravellerRequest> Travellers { get; set; }

    }
}

 


 



