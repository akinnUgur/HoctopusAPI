using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.BookingDTOs
{
    public class ReservationInfo
    {
        public required string BookingNumber { get; set; }
        public required Price SalePrice { get; set; }
        public required string BeginDate { get; set; }
        public required string EndDate { get; set; }

    }
}
