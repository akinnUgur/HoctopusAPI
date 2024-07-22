using HotelBookAPI.Application.DTOs.Common.HotelParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.OfferClasses
{
    public class Room
    {
        public string? RoomId { get; set; }

        public string? RoomName { get; set; }

        public string? BoardId { get; set; }
        public string? BoardName { get; set; }

        public List<BoardGroup>? BoardGroups { get; set; }

    }
}
