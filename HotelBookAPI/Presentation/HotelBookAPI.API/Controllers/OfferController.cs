using HotelBookAPI.Application.Features.GetOffers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : BaseApiController
    {

        [HttpPost("GetOffers")]
        public async Task<IActionResult> GetOffersAsync(GetOffersRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
