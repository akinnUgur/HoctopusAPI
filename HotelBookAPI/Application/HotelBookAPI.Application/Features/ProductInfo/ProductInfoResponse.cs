using HotelBookAPI.Application.DTOs.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.ProductInfo
{
    public class ProductInfoResponse
    {
        public ProductInfoHeader Header{ get; set; }

        public ProductInfoBody? Body{ get; set; }
    }
    //deneme commit 
    public class ProductInfoHeader
    {
        public string RequestId { get; set; }
        public bool Success { get; set; }
        public List<ProductInfoMessages> Messages { get; set; }
    }
    public class ProductInfoMessages
    {
        public int Id { get; set; }
        public string Message { get; set; }

    }


    public class ProductInfoBody
    {
        public ProductInfoHotel Hotel { get; set; }
    }

    public class  ProductInfoHotel
    {
        public List<ProductInfoSeasons> Seasons { get; set; }
        public Geolocation Geolocation{ get; set; }
        public string PhoneNumber { get; set; }
        public string HomePage { get; set; }

        public double Stars{ get; set; }

        public string ThumbnailFull { get; set; }

        [JsonProperty("description.text")]
        public string Text{ get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

    }

    public class ProductInfoSeasons
    {
        public string Name { get; set; }
        public List<ProductInfoFacilityCategories> FacilityCategories { get; set; }
        public List<ProductInfoMediaFiles> MediaFiles { get; set; }

    }

    public class ProductInfoFacilityCategories
    {
        public string Name { get; set; }
        public List<ProductInfoFacilites> Facilities { get; set; }

    }
    public class ProductInfoFacilites
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsPriced { get; set; }
    }
    public class ProductInfoMediaFiles
    {
        public int FileType { get; set; }
        public string UrlFull { get; set; }
    }
}
