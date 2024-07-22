
using HotelBookAPI.Application.Features.AutoComplete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IAutoCompleteService
    {
        Task<AutoCompleteResponse> GetAutoCompleteDataAsync(AutoCompleteRequest request, CancellationToken cancellationToken);
    }
}
