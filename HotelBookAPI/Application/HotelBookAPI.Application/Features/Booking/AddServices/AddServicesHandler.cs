using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.AddServices
{
    public class AddServicesHandler : CommonHandler, IRequestHandler<AddServicesRequest, AddServicesResponse>
    {
        public readonly IAddServicesService _addServicesService;

        public AddServicesHandler(IMapper mapper, IAddServicesService addServicesService) : base(mapper)
        {
            _addServicesService = addServicesService;
        }
        public Task<AddServicesResponse> Handle(AddServicesRequest request, CancellationToken cancellationToken)
        {
            return _addServicesService.AddServicesAsync(request, cancellationToken);
        }

    }
}
