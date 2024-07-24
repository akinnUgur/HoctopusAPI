using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AutoComplete
{
    public class AutoCompleteRequest : IRequest<AutoCompleteResponse>
    {
        [JsonIgnore]
        public int ProductType { get; set; } = 2;

        public required string Query { get; set; }

        [JsonIgnore]
        public string Culture { get; set; } = "en-US";

    }
}
