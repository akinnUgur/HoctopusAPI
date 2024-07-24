using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelDatas
{
    public class Facilites
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public bool IsPriced { get; set; }
    }
}
