
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.RemoveServices
{
    public class RemoveServicesRequest : IRequest<RemoveServicesResponse>
    {
        public string TransactionId { get; set; }

        public List<string> Services { get; set; }

        public string Currency { get; set; }

        public string Culture { get; set; }
    }
}
