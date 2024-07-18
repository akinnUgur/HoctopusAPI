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
     

        public GetReservationDetailsHandler(IMapper mapper) : base(mapper)
        {
          
        }

        public Task<GetReservationDetailsResponse> Handle(GetReservationDetailsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
