﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AutoComplete
{
    public class AutoCompleteRequest : IRequest<AutoCompleteResponse>
    {
        public string Query { get; set; }
        public string Culture { get; set; }

    }
}
