using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Settings
{
    public class HttpClientSettings
    {
        public string BaseAddress { get; set; }
        public string Name { get; set; }

        public string Agency { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
