using HotelBookAPI.Application.Features.SetReservationInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IReservationService
    {
        Task<SetReservationInfoResponse> SetReservationInfoAsync(SetReservationInfoRequest request, CancellationToken cancellationToken);     
    }
}
