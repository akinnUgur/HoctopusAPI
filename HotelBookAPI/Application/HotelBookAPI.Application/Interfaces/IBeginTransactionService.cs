using HotelBookAPI.Application.Features.Booking.WithOffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IBeginTransactionService
    {
        Task<BeginTransactionResponse> BeginTransactionWithOfferAsync(BeginTransactionWithOfferRequest request, CancellationToken 
            cancellationToken);

    }
}
