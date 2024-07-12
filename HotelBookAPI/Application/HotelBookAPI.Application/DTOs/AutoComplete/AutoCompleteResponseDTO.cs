using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.AutoComplete
{
    public class AutoCompleteResponseDTO
    {
        public AutoCompleteResponseBody Body { get; set; }
    }
    public class AutoCompleteResponseBody
    {
        public List<Item> Items { get; set; }
    }
    public class Item
    {
        public int Type { get; set; }
        public Geolocation Geolocation { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public Common.City City { get; set; }
        public Hotel Hotel { get; set; }
        public int Provider { get; set; }
    }


    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class State
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }


    public class Hotel
    {
        public string InternationalName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
