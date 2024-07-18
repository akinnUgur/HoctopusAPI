using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.GetReservationDetails;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetReservationDetailsController : BaseApiController
    {
        [HttpPost("GetReservationDetails")]
        public async Task<IActionResult> GetReservationDetails(GetReservationDetailsRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
