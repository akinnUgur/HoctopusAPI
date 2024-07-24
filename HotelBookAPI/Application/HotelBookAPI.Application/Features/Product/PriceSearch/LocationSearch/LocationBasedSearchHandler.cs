using AutoMapper;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Features.Product.PriceSearch;
using HotelBookAPI.Application.Interfaces;

using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.PriceSearch.LocationSearch
{
    public class LocationBasedSearchHandler : CommonHandler, IRequestHandler<LocationBasedSearchRequest, PriceSearchResponse>
    {
        private readonly IPriceSearchService _priceSearchService;

        public LocationBasedSearchHandler(IMapper mapper, IPriceSearchService priceSearchService) : base(mapper)
        {
            _priceSearchService = priceSearchService;

        }

        public async Task<PriceSearchResponse> Handle(LocationBasedSearchRequest request, CancellationToken cancellationToken)
        {

            return await _priceSearchService.LocationBasedSearchAsync(request, cancellationToken);
        }
    }
}
