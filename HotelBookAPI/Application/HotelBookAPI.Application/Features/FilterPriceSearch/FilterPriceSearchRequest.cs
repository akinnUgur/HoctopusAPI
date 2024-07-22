using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.FilterPriceSearch
{
    public class FilterPriceSearchRequest : IRequest<FilterPriceSeachResponse>
    {
        public string SearchId { get; set; }
        public string Culture { get; set; }
        public string Currency { get; set; }
    }

    public class PagingOptions
    {
        public int CurrentPage { get; set; }
        public bool GetFilters { get; set; } = true;
        public bool IsNewPagingRequest { get; set; } = true;
        public int PageRowCount { get; set; } = 50;
        public int ProductCount { get; set; } = 2;
        public int Sort { get; set; } = 0;

        public List<Filter> Filters { get; set; }



    }
    /// <summary>
    /// type 8 = price {type, from, to}
    /// type 2 = star {values ["4", "5"]}
    /// type 6 = boards {values["all inclusive", "bed & breakfast"] }
    /// type 4 = themes {values["32"]}
    /// type 7 = facilities {values ["5"]}
    /// 
    /// </summary>
    public class Filter
    {
        public int? From { get; set; }
        public int? To { get; set; }
        public int Type { get; set; }
        public List<string> Values { get; set; }

    }

  
}
