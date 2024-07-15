using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.BusinessModels
{
    public enum TourVisioServices
    {
        [Description("productservice/getarrivalautocomplete")]
        AutoComplete,
        [Description("productservice/pricesearch")]
        PriceSearch,
        [Description("authenticationservice/login")]
        Authanticate,



    }
}
