using HotelBookAPI.Application.DTOs.AutoComplete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IAutoCompleteService
    {
        Task<AutoCompleteResponseDTO> GetAutoCompleteDataAsync(AutoCompleteRequestDTO request, CancellationToken cancellationToken);
    }
}
