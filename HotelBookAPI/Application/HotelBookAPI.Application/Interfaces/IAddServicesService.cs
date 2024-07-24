using HotelBookAPI.Application.Features.Booking.AddServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IAddServicesService
    {
        Task<AddServicesResponse> AddServicesAsync(AddServicesRequest request, CancellationToken cancellationToken);

    }
}
