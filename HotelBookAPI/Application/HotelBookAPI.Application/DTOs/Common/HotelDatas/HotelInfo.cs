using HotelBookAPI.Application.Features.ProductInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelDatas
{
    public class HotelInfo
    {
        public List<ProductInfoSeasons> Seasons { get; set; }
        public Geolocation Geolocation { get; set; }
        public string PhoneNumber { get; set; }
        public string? HomePage { get; set; }

        public required double Stars { get; set; }

        public string? ThumbnailFull { get; set; }

        [JsonProperty("description.text")]
        public string Text { get; set; }
        public required string Id { get; set; }
        public required string Name { get; set; }

    }
}
