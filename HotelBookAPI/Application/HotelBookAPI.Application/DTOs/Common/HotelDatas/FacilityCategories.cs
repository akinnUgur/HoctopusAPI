using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelDatas
{
    public class FacilityCategories
    {
        public required string Name { get; set; }
        public List<Facilites>? Facilities { get; set; }

    }
}
