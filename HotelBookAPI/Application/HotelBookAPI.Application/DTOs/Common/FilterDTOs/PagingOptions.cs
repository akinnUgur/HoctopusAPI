using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.FilterDTOs
{
    public class PagingOptions
    {
        public int CurrentPage { get; set; }
        public bool GetFilters { get; set; } = true;
        public bool IsNewPagingRequest { get; set; } = true;
        public int PageRowCount { get; set; } = 50;

        [JsonIgnore]
        public int ProductType { get; set; } = 2;
        public int Sort { get; set; } = 0;

        public List<Filter>? Filters { get; set; }
    }
}
