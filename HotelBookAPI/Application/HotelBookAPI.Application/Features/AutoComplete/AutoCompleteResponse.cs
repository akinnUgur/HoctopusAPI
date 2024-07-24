using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AutoComplete
{
    public class AutoCompleteResponse
    {
        public required Header Header { get; set; }
        public AutoCompleteResponseBody? Body { get; set; }
    }
    public class AutoCompleteResponseBody
    {
        public List<AutoCompleteItem>? Items { get; set; }
    }
 
}
