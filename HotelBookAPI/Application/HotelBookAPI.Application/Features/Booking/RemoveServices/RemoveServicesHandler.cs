using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.RemoveServices
{
    public class RemoveServicesHandler : CommonHandler, IRequestHandler<RemoveServicesRequest, RemoveServicesResponse>
    {
        public readonly IRemoveServicesService _removeServicesService;

        public RemoveServicesHandler(IMapper mapper, IRemoveServicesService RemoveServicesService) : base(mapper)
        {
            _removeServicesService = RemoveServicesService;
        }
        public Task<RemoveServicesResponse> Handle(RemoveServicesRequest request, CancellationToken cancellationToken)
        {
            return _removeServicesService.RemoveServicesAsync(request, cancellationToken);
        }

    }




}


