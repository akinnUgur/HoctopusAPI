using HotelBookAPI.Application.Features.Product.GetOfferDetails;
using HotelBookAPI.Application.Features.Product.GetOffers;
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

        [HttpPost("GetOfferDetails")]
        public async Task<IActionResult> GetOfferDetailsAsync(GetOfferDetailsRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }

    }
}
