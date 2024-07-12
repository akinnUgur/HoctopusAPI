using HotelBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Infrastructure.Managers
{
    public class TourVisioManager : ITourVisioManager
    {
        public IPriceSearchService PriceSearchService { get; }
        public IAutoCompleteService autoCompleteService { get; }

        public TourVisioManager(IPriceSearchService priceSearchService, IAutoCompleteService autoCompleteService)
        {
            PriceSearchService = priceSearchService;
            this.autoCompleteService = autoCompleteService;
        }
    }
}
