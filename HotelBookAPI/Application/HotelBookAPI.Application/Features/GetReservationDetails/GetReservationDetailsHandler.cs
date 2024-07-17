using AutoMapper;
using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetReservationDetails
{
    public class GetReservationDetailsHandler : CommonHandler, IRequestHandler<GetReservationDetailsRequest, GetReservationDetailsResponse>
    {
        public readonly IGetReservationDetailsService _getReservationDetailsService;

        public GetReservationDetailsHandler(IMapper mapper, IGetReservationDetailsService getReservationDetailsService) : base(mapper)
        {
            _getReservationDetailsService = getReservationDetailsService;
        }
        public Task<GetReservationDetailsResponse> Handle(GetReservationDetailsRequest request, CancellationToken cancellationToken)
        {
            return _getReservationDetailsService.GetReservationDetailsAsync(request, cancellationToken);
        }
    }
}
