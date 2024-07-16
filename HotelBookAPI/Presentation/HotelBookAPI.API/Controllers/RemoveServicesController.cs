using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.RemoveServices;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveServicesController : BaseApiController
    {
        [HttpPost("RemoveServices")]

        public async Task<IActionResult> RemoveServices(RemoveServicesRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
