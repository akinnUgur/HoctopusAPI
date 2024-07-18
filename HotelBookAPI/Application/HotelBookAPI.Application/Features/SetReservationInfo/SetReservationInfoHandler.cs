using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.SetReservationInfo
{
    public class SetReservationInfoHandler : CommonHandler, IRequestHandler<SetReservationInfoRequest, SetReservationInfoResponse>
    {
        private readonly IReservationService _reservationService;
        public SetReservationInfoHandler(IMapper mapper, IReservationService reservationService) : base(mapper)
        {
            _reservationService = reservationService;
        }

        public async Task<SetReservationInfoResponse> Handle(SetReservationInfoRequest request, CancellationToken cancellationToken)
        {
            return await _reservationService.SetReservationInfoAsync(request, cancellationToken);
        }
    }
}
