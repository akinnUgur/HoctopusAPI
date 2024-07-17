using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionWithOfferRequest: IRequest<BeginTransactionResponse>
    {
        public List<string> OfferIds { get; set; }

        public string Currency { get; set; }

        public string Culture { get; set; }
    }
}
