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


        public ProductInfoBody? Body{ get; set; }
    }




    public class ProductInfoBody
    {
        public HotelInfo Hotel { get; set; }
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
