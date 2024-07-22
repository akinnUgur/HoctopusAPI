using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.Features.PriceSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.FilterPriceSearch
{
    public class FilterPriceSeachResponse
    {
        public Header Header { get; set; }

        public FilterPriceSearchBody? Body { get; set; }

    }

    public class FilterPriceSearchBody
    {
        public string SearchId { get; set; }
        public string ExpiresOn { get; set; }
        public int ProductCount { get; set; }
        public List<Hotel> Hotels { get; set; }
    }

   ///Filtrelenebilir otel sayılar (3 stars = 5 hotels gibi) eklenebilir
}
