using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Settings
{
    public class HttpClientSettings
    {
        public required string BaseAddress { get; set; }
        public required string Name { get; set; }

        public required string Agency { get; set; }
        public required string User { get; set; }
        public required string Password { get; set; }
    }
}
