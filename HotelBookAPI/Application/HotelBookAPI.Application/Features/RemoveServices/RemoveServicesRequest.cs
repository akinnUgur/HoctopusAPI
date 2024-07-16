using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.RemoveServices
{
    public class RemoveServicesRequest
    {
        public string TransactionId { get; set; }

        public List<string> Offers { get; set; }

        public string Currency { get; set; }

        public string Culture { get; set; }
    }
}
