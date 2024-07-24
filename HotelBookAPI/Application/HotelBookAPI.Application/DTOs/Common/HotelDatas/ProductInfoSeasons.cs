using HotelBookAPI.Application.Features.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelDatas
{
    public class ProductInfoSeasons
    {
        public string? Name { get; set; }
        public List<FacilityCategories>? FacilityCategories { get; set; }
        public List<MediaFiles>? MediaFiles { get; set; }

    }
}
