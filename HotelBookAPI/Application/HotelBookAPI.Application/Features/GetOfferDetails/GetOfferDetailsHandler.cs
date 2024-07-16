using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOfferDetails
{
    public class GetOfferDetailsHandler : CommonHandler, IRequestHandler<GetOfferDetailsRequest, GetOfferDetailsResponse>
    {
        private readonly IOfferService _offerService;
        public GetOfferDetailsHandler(IMapper mapper, IOfferService offerService) : base(mapper)
        {
            _offerService = offerService;
        }

        public async Task<GetOfferDetailsResponse> Handle(GetOfferDetailsRequest request, CancellationToken cancellationToken)
        {
           return await _offerService.GetOfferDetailsAsync(request, cancellationToken);
        }
    }
}
