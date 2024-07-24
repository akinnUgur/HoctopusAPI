using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class Price
    {
        public required double Amount { get; set; }
        public required string Currency { get; set; }
    }
}
