using HotelBookAPI.Application.DTOs.Common.OfferClasses;
using HotelBookAPI.Application.Features.PriceSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelParts
{
    public class Hotel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Geolocation? Geolocation { get; set; }
        public float Stars { get; set; }
        public GenericLocation? City { get; set; }
        public List<Offer>? Offers { get; set; }
        public string? Address { get; set; }
        public string? ThumbnailFull { get; set; }
        public List<BoardGroup>? BoardGroups { get; set; }


    }
}
