using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Product.GetOffers
{
    public class GetOffersHandler : CommonHandler, IRequestHandler<GetOffersRequest, GetOffersResponse>
    {
        private readonly IOfferService _offerService;
        public GetOffersHandler(IMapper mapper, IOfferService offerService) : base(mapper)
        {
            _offerService = offerService;
        }

        public async Task<GetOffersResponse> Handle(GetOffersRequest request, CancellationToken cancellationToken)
        {
            return await _offerService.GetOffersAsync(request, cancellationToken);
        }
    }
}
