using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class Header
    {

        public required string RequestId { get; set; }
        public bool Success { get; set; }
        public required List<Message> Messages { get; set; }
    }
    public class Message
    {
        public int Id { get; set; }
        public required string Code { get; set; }

        [JsonProperty("message")]
        public required string msg { get; set; }
    }
}
