using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelParts
{
    public class HotelCategory
    {
        public required string Name { get; set; }
        public required string Id { get; set; }
        public string? Code { get; set; }

    }
}
