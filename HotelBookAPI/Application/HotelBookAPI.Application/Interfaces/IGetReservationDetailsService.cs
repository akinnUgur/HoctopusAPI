using HotelBookAPI.Application.Features.GetReservationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IGetReservationDetailsService
    {
        Task<GetReservationDetailsResponse> GetReservationDetailsAsync(GetReservationDetailsRequest request, CancellationToken cancellationToken);

    }
}
