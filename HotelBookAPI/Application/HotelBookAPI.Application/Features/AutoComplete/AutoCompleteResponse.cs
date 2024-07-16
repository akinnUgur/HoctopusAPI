using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.AutoComplete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AutoComplete
{
    public class AutoCompleteResponse
    {
        public Header Header{ get; set; }
        public ICollection<AutoCompleteItem> Items { get; set; }


    }
}
