using HotelBookAPI.Application.DTOs.BookingDTOs;
using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelBookAPI.Application.Features.Booking.AddServices
{
    public class AddServicesResponse
    {
        public required Header Header { get; set; }

        public AddServicesBody? Body { get; set; }
    }
    public class AddServicesBody
    {
        public required string TransactionId { get; set; }

        public required string ExpiresOn { get; set; }

        public ReservationData? ReservationData { get; set; }

        public int Status { get; set; }

    }
  
}
