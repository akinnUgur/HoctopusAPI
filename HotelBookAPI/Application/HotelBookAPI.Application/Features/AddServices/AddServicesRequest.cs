using HotelBookAPI.Application.Features.PriceSearch;
using HotelBookAPI.Application.Features.ProductInfo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AddServices
{
    public class AddServicesRequest : IRequest<AddServicesResponse>
    {
        public string TransactionId { get; set; }

        public List<Offer> Offers { get; set; }

        public string Currency { get; set; }

        public string Culture { get; set; }
    }
    public class Offer
    {
        public string OfferId { get; set; }

        public List<string> Travellers { get; set; }
    }
}
