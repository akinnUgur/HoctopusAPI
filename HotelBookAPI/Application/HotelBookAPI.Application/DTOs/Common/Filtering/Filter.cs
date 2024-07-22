using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.Filtering
{
    /// <summary>
    /// type 8 = price {type, from, to}
    /// type 2 = star {values ["4", "5"]}
    /// type 6 = boards {values["all inclusive", "bed & breakfast"] }
    /// type 4 = themes {values["32"]}
    /// type 7 = facilities {values ["5"]}
    /// 
    /// </summary>  
    public class Filter
    {
        public int? From { get; set; }
        public int? To { get; set; }
        public int Type { get; set; }
        public List<string>? Values { get; set; }

    }
}
