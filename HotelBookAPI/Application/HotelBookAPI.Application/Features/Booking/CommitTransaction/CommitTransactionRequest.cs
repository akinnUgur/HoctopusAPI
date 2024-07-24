using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.CommitTransaction
{
    public class CommitTransactionRequest : IRequest<CommitTransactionResponse>
    {
        public string TransactionId { get; set; }

    }
}
