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

        public List<string> Offers { get; set; }

        public string Currency { get; set; }

        public string Culture { get; set; }
    }
}
