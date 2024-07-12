using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.AutoComplete
{
    public class AutoCompleteRequestDTO
    {
        public int ProductType { get; set; }
        public string Query { get; set; }
        public string Culture { get; set; }
    }
}
