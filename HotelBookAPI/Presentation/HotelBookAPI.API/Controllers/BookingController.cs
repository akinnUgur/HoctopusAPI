using HotelBookAPI.Application.Features.SetReservationInfo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseApiController
    {
        [HttpPost("SetReservationInfo")]
        public async Task<IActionResult> SetReservationInfo(SetReservationInfoRequest request)
        {
            var data = Mediator.Send(request);
            return Ok(data);    
        }
    }
}
