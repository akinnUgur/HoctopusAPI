using HotelBookAPI.Application.DTOs.Common.Filtering;
using MediatR;


namespace HotelBookAPI.Application.Features.FilterPriceSearch
{
    public class FilterPriceSearchRequest : IRequest<FilterPriceSeachResponse>
    {
        public string SearchId { get; set; }
        public string Culture { get; set; }
        public string Currency { get; set; }

        public List<PagingOptions> PagingOptions { get; set; }
    }
}
