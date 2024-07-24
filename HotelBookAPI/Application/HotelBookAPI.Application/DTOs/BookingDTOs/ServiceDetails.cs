using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.BookingDTOs
{
    public class ServiceDetails
    {
        public required string ServiceId { get; set; }
        public string? Thumbnail { get; set; }
        public required int Night { get; set; }

        public required HotelServiceDetail HotelDetails { get; set; }
        public required string Board { get; set; }
        public required string Room { get; set; }



    }
}
