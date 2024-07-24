using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class PassportInfo
    {
        public string? Serial { get; set; }
        public string? Number { get; set; }
        public string? ExpireDate { get; set; }
        public string? IssueDate { get; set; }
        public string? CitizenshipCountryCode { get; set; }


    }
}
