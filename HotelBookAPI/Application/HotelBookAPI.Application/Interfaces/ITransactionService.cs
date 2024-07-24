using HotelBookAPI.Application.Features.Booking.CommitTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface ITransactionService
    {
        Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request, CancellationToken cancellationToken);
    }
}
