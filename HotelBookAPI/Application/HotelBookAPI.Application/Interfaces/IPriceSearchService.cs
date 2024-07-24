using HotelBookAPI.Application.Features.Product.PriceSearch;
using HotelBookAPI.Application.Features.Product.PriceSearch.HotelSearch;
using HotelBookAPI.Application.Features.Product.PriceSearch.LocationSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IPriceSearchService
    {
        Task<PriceSearchResponse> LocationBasedSearchAsync(LocationBasedSearchRequest request, CancellationToken cancellationToken);

        Task<PriceSearchResponse> HotelBasedSearchAsync(HotelBasedSearchRequest request, CancellationToken cancellationToken);
    }
}
