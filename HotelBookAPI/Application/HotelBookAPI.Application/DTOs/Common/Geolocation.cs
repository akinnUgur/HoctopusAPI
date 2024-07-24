using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class Geolocation
    {
        public required string Longitude { get; set; }
        public required string Latitude { get; set; }
    }
}
