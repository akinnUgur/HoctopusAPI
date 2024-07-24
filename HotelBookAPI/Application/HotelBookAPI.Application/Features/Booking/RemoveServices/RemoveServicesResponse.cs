using HotelBookAPI.Application.DTOs.BookingDTOs;
using HotelBookAPI.Application.DTOs.Common;

namespace HotelBookAPI.Application.Features.Booking.RemoveServices
{
    public class RemoveServicesResponse
    {
        public required Header Header { get; set; }

        public RemoveServicesBody? Body { get; set; }
    }
    public class RemoveServicesBody
    {
        public required string TransactionId { get; set; }

        public required string ExpiresOn { get; set; }

        public ReservationData? ReservationData { get; set; }

        public int Status { get; set; }

    }
  
}
