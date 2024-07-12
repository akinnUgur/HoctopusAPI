using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.AutoComplete
{
    public class AutoCompleteItem
    {
        public AutoCompleteCountry Country { get; set; }
        public City City { get; set; }
        public AutoCompleteHotel Hotel { get; set; }
    }
}
