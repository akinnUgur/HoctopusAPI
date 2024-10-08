﻿using HotelBookAPI.Application.DTOs.Common.FilterDTOs;
using MediatR;
using System.Text.Json.Serialization;


namespace HotelBookAPI.Application.Features.Product.FilterPriceSearch
{
    public class FilterPriceSearchRequest : IRequest<FilterPriceSeachResponse>
    {
        public required string SearchId { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";

        public required string Currency { get; set; }

        public List<PagingOptions>? PagingOptions { get; set; }
    }
}
