using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class HotelServiceDetail
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Geolocation Geolocation { get; set; }

    }
}
