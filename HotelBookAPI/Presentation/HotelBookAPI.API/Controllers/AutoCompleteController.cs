using HotelBookAPI.Application.Features.AutoComplete;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoCompleteController : BaseApiController
    {

        [HttpPost("AutoComplete")]
        public async Task<IActionResult> AutoComplete([FromBody] AutoCompleteRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
