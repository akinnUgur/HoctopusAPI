using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetOffers
{
    public class GetOffersRequest : IRequest<GetOffersResponse>
    {
        public string SearchId{ get; set; }
        public string OfferId { get; set; }
        public int ProductType { get; set; } = 2;
        public string Currency { get; set; }
        public string Culture { get; set; }
        public bool GetRoomInfo { get; set; } = true;


    }
}
