using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;

namespace HotelBookAPI.Application.Features.Product.FilterPriceSearch
{
    public class FilterPriceSearchHandler : CommonHandler, IRequestHandler<FilterPriceSearchRequest, FilterPriceSeachResponse>
    {
        private readonly IFilterPriceSearchService _filterPriceSearchService;
        public FilterPriceSearchHandler(IMapper mapper, IFilterPriceSearchService filterPriceSearchService) : base(mapper)
        {
            _filterPriceSearchService = filterPriceSearchService;
        }

        public async Task<FilterPriceSeachResponse> Handle(FilterPriceSearchRequest request, CancellationToken cancellationToken)
        {
            return await _filterPriceSearchService.FilterSearchAsync(request, cancellationToken);
        }
    }
}
