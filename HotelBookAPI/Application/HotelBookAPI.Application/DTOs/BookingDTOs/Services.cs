using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.BookingDTOs
{
    public class Services
    {
        public required int OrderNumber { get; set; }
        public required bool IsMainService { get; set; }
       
    }
}
