using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.BookingDTOs
{
    public class ReservationData
    {
        public required ReservationInfo ReservationInfo { get; set; }
    }
}
