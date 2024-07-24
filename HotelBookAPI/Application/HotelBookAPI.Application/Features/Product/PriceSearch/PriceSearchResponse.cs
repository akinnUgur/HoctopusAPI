using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelParts;


namespace HotelBookAPI.Application.Features.Product.PriceSearch
{

    /// <summary>
    /// Reuest_id ve oFfer Id ve product Id getoffers endpoitinde kullanılacak
    /// search_id filterda kullanılacak
    /// </summary>
    public class PriceSearchResponse
    {
        public required Header Header { get; set; }
        public PriceSearchResponseBody? Body { get; set; }

    }

    public class PriceSearchResponseBody
    {
        public required string SearchId { get; set; }
        public required string ExpiresOn { get; set; }
        public List<Hotel>? Hotels { get; set; }

    }
}
