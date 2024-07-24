using HotelBookAPI.Application.DTOs.Common;
using MediatR;
using System;


namespace HotelBookAPI.Application.Features.Booking.SetReservationInfo
{
    public class SetReservationInfoRequest : IRequest<SetReservationInfoResponse>
    {
        public string TransactionId { get; set; }
        public required List<Traveller> Travellers { get; set; }

    }
}

 


 



