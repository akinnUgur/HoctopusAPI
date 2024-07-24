using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookAPI.Application.DTOs.Common;

namespace HotelBookAPI.Application.DTOs.AutoComplete
{
    public class AutoCompleteItem
    {
        public int Type { get; set; }
        public Geolocation? Geolocation { get; set; }
        public GenericLocation? Country { get; set; }
        public GenericLocation? City { get; set; }
        public GenericLocation? Hotel { get; set; }
    }
}
