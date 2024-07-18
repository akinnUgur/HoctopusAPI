using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.CommitTransaction
{
    public class CommitTransactionHandler : CommonHandler, IRequestHandler<CommitTransactionRequest, CommitTransactionResponse>
    {


        private readonly ITransactionService _transactionService;
        public CommitTransactionHandler(IMapper mapper, ITransactionService transactionService) : base(mapper)
        {
         _transactionService = transactionService;
        }

        public async Task<CommitTransactionResponse> Handle(CommitTransactionRequest request, CancellationToken cancellationToken)
        {
           return await _transactionService.CommitTransactionAsync(request, cancellationToken);
        }
    }
}
