using HotelBookAPI.Application.DTOs.BookingDTOs;
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using Newtonsoft.Json;

namespace HotelBookAPI.Application.Features.Booking.SetReservationInfo
{
    public class SetReservationInfoResponse
    {
        public required Header Header { get; set; }
        public SetReservationInfoResponseBody? Body { get; set; }
    }

    public class SetReservationInfoResponseBody
    {
      
        public required string TransactionId { get; set; }
    
        public required string ExpiresOn { get; set; }
        public int Status { get; set; }
        public required ReservationData ReservationData { get; set; }
    }
  
 

}
