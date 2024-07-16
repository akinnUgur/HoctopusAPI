using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.ProductInfo;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddServicesController : BaseApiController
    {
        [HttpPost("AddServices")]
        public async Task<IActionResult> AddServices(AddServicesRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }

    }
}
