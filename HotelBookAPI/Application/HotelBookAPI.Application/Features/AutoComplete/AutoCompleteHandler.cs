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
        private readonly DTOService _dtoService;

        public AutoCompleteHandler(IMapper mapper, IAutoCompleteService autocompleteService, DTOService dtoService) : base(mapper)
        {
            _autocompleteService = autocompleteService;
            _dtoService = dtoService;
        }

        public async Task<AutoCompleteResponse> Handle(AutoCompleteRequest request, CancellationToken cancellationToken)
        {
            var dto = await _autocompleteService.GetAutoCompleteDataAsync(_dtoService.AutoCompleteRequestTransfer(request), cancellationToken);
            return _dtoService.AutoCompleteResponseTransfer(dto);
        }

    }
}
