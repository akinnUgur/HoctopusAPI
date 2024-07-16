using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOfferDetails
{
    public class GetOfferDetailsRequest : IRequest<GetOfferDetailsResponse>
    {
        public List<string> OfferIds { get; set; }
        public string Currency { get; set; }
        public bool GetProductInfo { get; set; } = true;
    }
}
