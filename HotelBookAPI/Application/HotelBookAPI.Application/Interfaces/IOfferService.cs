using HotelBookAPI.Application.Features.GetOffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IOfferService
    {
        Task<GetOffersResponse> GetOffersAsync(GetOffersRequest request, CancellationToken cancellationToken);
    }
}
