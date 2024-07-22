using HotelBookAPI.Application.DTOs.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.PriceSearch
{

    /// <summary>
    /// ReuestID ve oFfer Id ve product Id getoffers endpoitinde kullanılacak
    /// </summary>
    public class PriceSearchResponse
    {
        public Body? Body { get; set; }
        public Header Header { get; set; }





    }

    public class Body
    {
        public string SearchId { get; set; }
        public string ExpiresOn { get; set; }
        public List<Hotel> Hotels { get; set; }

    }

    public class Hotel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Geolocation? Geolocation { get; set; }
        public float Stars { get; set; }
        public GenericLocation City { get; set; }
        public List<Offer> Offers { get; set; }
        public string Address { get; set; }
        public string? ThumbnailFull { get; set; }
        public List<BoardGroup> BoardGroups { get; set; }


    }

    public class Offer
    {
        public int Night { get; set; }
        public bool IsAvailable { get; set; }
        public int Availability { get; set; }

        public List<Room> Rooms { get; set; }
        public bool IsRefundable { get; set; }

        public string ExpiresOn { get; set; }
        public string OfferId { get; set; }
        public string CheckIn { get; set; }

        public Price Price { get; set; }
    }
    public class Room
    {
        public string RoomId { get; set; }

        public string RoomName { get; set; }

        public string BoardId { get; set; }
        public string BoardName { get; set; }

        public List<BoardGroup> BoardGroups { get; set; }



    }
}
