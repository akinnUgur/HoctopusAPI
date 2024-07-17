﻿using HotelBookAPI.Application.Features.AddServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetReservationDetails
{
    public class GetReservationDetailsRequest : IRequest<GetReservationDetailsResponse>
    {
        public string ReservationNumber { get; set; }
    }
}
