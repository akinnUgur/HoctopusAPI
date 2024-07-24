using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelParts;


namespace HotelBookAPI.Application.Features.FilterPriceSearch
{
    public class FilterPriceSeachResponse
    {
        public required Header Header { get; set; }

        public FilterPriceSearchBody? Body { get; set; }

    }

    public class FilterPriceSearchBody
    {
        public required string SearchId { get; set; }
        public required string ExpiresOn { get; set; }
        public int ProductCount { get; set; }
        public List<Hotel>? Hotels { get; set; }
    }

   ///Filtrelenebilir otel sayıları (3 stars = 5 hotels gibi) eklenebilir
}
