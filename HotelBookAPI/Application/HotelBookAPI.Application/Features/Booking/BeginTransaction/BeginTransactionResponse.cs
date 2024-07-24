using HotelBookAPI.Application.DTOs.BookingDTOs;
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelDatas;
using HotelBookAPI.Application.Features.Booking.AddServices;


namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionResponse
    {
        public required Header Header { get; set; }
        public BeginTransactionBody? Body { get; set; }

    }




    public class BeginTransactionBody
    {
        public required string TransactionId { get; set; }
        public required string ExpiresOn { get; set; }

        public required ReservationData ReservationData { get; set; }
        public int Status { get; set; }

    }

}



