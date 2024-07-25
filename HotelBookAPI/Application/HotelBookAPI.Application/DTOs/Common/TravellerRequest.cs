using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class TravellerRequest : Traveller
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public Addres Address { get; set; }

    }
}
