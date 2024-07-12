using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.PriceSearch.LocationSearch
{
    public class LocationBasedSearchHandler : CommonHandler, IRequestHandler<LocationBasedSearchRequest, PriceSearchResponse>
    {
        private readonly IPriceSearchService _priceSearchService;
        private readonly DTOService _dtoService;
        public LocationBasedSearchHandler(IMapper mapper, IPriceSearchService priceSearchService, DTOService dtoService) : base(mapper)
        {
            _priceSearchService = priceSearchService;
            _dtoService = dtoService;
        }

        public async Task<PriceSearchResponse> Handle(LocationBasedSearchRequest request, CancellationToken cancellationToken)
        {
            var dto = _dtoService.ConvertPriceSearchRequest(request);
            return await _priceSearchService.LocationBasedSearchAsync(dto, cancellationToken);
        }
    }
}
