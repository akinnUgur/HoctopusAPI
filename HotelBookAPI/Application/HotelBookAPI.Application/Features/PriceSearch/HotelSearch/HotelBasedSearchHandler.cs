using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.PriceSearch.HotelSearch
{
    public class HotelBasedSearchHandler : CommonHandler, IRequestHandler<HotelBasedSearchRequest, PriceSearchResponse>
    {
        private readonly IPriceSearchService _priceSearchService;
       
        public HotelBasedSearchHandler(IMapper mapper, IPriceSearchService priceSearchService) : base(mapper)
        {
            _priceSearchService = priceSearchService;
       
        }

        public async Task<PriceSearchResponse> Handle(HotelBasedSearchRequest request, CancellationToken cancellationToken)
        {
            return await _priceSearchService.HotelBasedSearchAsync(request, cancellationToken);
        }
    }
}
