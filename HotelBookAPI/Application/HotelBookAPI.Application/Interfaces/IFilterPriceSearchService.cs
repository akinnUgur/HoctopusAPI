using HotelBookAPI.Application.Features.FilterPriceSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IFilterPriceSearchService
    {
        Task<FilterPriceSeachResponse> FilterSearchAsync(FilterPriceSearchRequest request, CancellationToken cancellationToken);
    }
}
