using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.DTOs.Common.AutoComplete;
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.PriceSearch;
using HotelBookAPI.Application.Features.AutoComplete;
using HotelBookAPI.Application.Features.PriceSearch.HotelSearch;
using HotelBookAPI.Application.Features.PriceSearch.LocationSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Services
{
    public class DTOService
    {

        public AutoCompleteRequestDTO AutoCompleteRequestTransfer(AutoCompleteRequest request)
        {
            return new()
            {
                ProductType = 2, //Hotel Product Id
                Query = request.Query,
                Culture = request.Culture,
            };
        }

        public AutoCompleteResponse AutoCompleteResponseTransfer(AutoCompleteResponseDTO dto)
        {
            var response = new AutoCompleteResponse
            {
                Items = new List<AutoCompleteItem>()
            };

            if (dto.Body != null && dto.Body.Items != null)
            {
                foreach (var dtoItem in dto.Body.Items)
                {
                    var item = new AutoCompleteItem
                    {
                        Country = new AutoCompleteCountry
                        {
                            Id = dtoItem.Country?.Id,
                            Name = dtoItem.Country?.Name
                        },
                        City = new AutoCompleteCity
                        {
                            Id = dtoItem.City?.Id,
                            Name = dtoItem.City?.Name
                        },
                        Hotel = new AutoCompleteHotel
                        {
                            Id = dtoItem.Hotel?.Id,
                            Name = dtoItem.Hotel?.Name
                        }
                    };

                    response.Items.Add(item);
                }
            }

            return response;
        }

        public HotelBasedSearchRequestDTO ConvertPriceSearchRequest(HotelBasedSearchRequest searchRequest)
        {
            return new()
            {
                CheckAllotment = true,
                CheckStopSale = true,
                GetOnlyDiscountedPrice = false,
                GetOnlyBestOffers = true,
                ProductType = 2,
                Products = searchRequest.Products,
                RoomCriteria = searchRequest.RoomCriteria,
                Nationality = searchRequest.Nationality,
                CheckIn = searchRequest.CheckIn,
                Night = searchRequest.Night,
                Currency = searchRequest.Currency,
                Culture = searchRequest.Culture,
            };
        }


        public LocationBasedSearchRequestDTO ConvertPriceSearchRequest(LocationBasedSearchRequest searchRequest)
        {

            return new()
            {
                CheckAllotment = true,
                CheckStopSale = true,
                GetOnlyDiscountedPrice = false,
                GetOnlyBestOffers = true,
                ProductType = 2,
                ArrivalLocations = searchRequest.ArrivalLocations,
                RoomCriteria = searchRequest.RoomCriteria,
                Nationality = searchRequest.Nationality,
                CheckIn = searchRequest.CheckIn,
                Night = searchRequest.Night,
                Culture = searchRequest.Culture,
                Currency = searchRequest.Currency,
            };

        }





    }
}
