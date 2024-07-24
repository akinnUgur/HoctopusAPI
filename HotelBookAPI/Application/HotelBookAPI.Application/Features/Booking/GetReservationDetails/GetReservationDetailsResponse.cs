using HotelBookAPI.Application.DTOs.BookingDTOs;
using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.GetReservationDetails
{
    public class GetReservationDetailsResponse
    {
        public required Header Header { get; set; }

        public GetReservationDetailBody? Body { get; set; }
    }
    public class GetReservationDetailBody
    {
        public required string ReservationNumber { get; set; }
        public required string EncryptedReservationNumber { get; set; }
        public required string TransactionId { get; set; }

        public required ReservationData ReservationData { get; set; }

        public int Status { get; set; }


    }
}
