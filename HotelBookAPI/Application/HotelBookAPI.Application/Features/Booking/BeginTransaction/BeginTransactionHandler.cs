using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionHandler : CommonHandler, IRequestHandler<BeginTransactionRequest, BeginTransactionResponse>
    {
        private readonly IBeginTransactionService _transactionService;
       

        public BeginTransactionHandler(IMapper mapper, IBeginTransactionService beginTransactionService):base(mapper)
        {
            _transactionService = beginTransactionService;
            
        }

        public Task<BeginTransactionResponse> Handle(BeginTransactionRequest request, CancellationToken cancellationToken)
        {
            return _transactionService.BeginTransactionWithOfferAsync(request, cancellationToken);  
        }
    }
}
