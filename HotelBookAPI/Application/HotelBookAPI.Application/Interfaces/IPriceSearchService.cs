using HotelBookAPI.Application.DTOs.PriceSearch;
using HotelBookAPI.Application.Features.PriceSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IPriceSearchService
    {
        Task<PriceSearchResponse> LocationBasedSearchAsync(LocationBasedSearchRequestDTO request, CancellationToken cancellationToken);

        Task<PriceSearchResponse> HotelBasedSearchAsync(HotelBasedSearchRequestDTO request, CancellationToken cancellationToken);
    }
}
