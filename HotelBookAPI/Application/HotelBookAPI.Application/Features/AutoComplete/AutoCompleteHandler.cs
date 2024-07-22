using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using HotelBookAPI.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.AutoComplete
{
    public class AutoCompleteHandler : CommonHandler, IRequestHandler<AutoCompleteRequest, AutoCompleteResponse>
    {

        private readonly IAutoCompleteService _autocompleteService;
   

        public AutoCompleteHandler(IMapper mapper, IAutoCompleteService autocompleteService) : base(mapper)
        {
            _autocompleteService = autocompleteService;
      
        }

        public async Task<AutoCompleteResponse> Handle(AutoCompleteRequest request, CancellationToken cancellationToken)
        {
           
            return await _autocompleteService.GetAutoCompleteDataAsync(request, cancellationToken);
        }

    }
}
