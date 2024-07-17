using AutoMapper;
using HotelBookAPI.Application.Features.Common;
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
        public SetReservationInfoHandler(IMapper mapper) : base(mapper)
        {
        }

        public Task<SetReservationInfoResponse> Handle(SetReservationInfoRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
