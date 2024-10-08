﻿using HotelBookAPI.Application.Features.Booking.RemoveServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IRemoveServicesService
    {
        Task<RemoveServicesResponse> RemoveServicesAsync(RemoveServicesRequest request, CancellationToken cancellationToken);

    }
}
