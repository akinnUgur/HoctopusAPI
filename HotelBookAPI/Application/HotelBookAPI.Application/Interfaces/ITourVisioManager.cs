using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public class ITourVisioManager
    {
        IAutoCompleteService autoCompleteService { get; }
        IPriceSearchService priceSearchService { get; }
    }
}
