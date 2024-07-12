using HotelBookAPI.Application.Features.PriceSearch.HotelSearch;
using HotelBookAPI.Application.Features.PriceSearch.LocationSearch;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceSearchController : BaseApiController
    {

        [HttpPost("HotelBasedSearch")]
        public async Task<IActionResult> HoteBasedlSearch([FromBody] HotelBasedSearchRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }

        [HttpPost("LocationBasedSearch")]
        public async Task<IActionResult> LocationBasedSearch([FromBody] LocationBasedSearchRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }


    }
}
