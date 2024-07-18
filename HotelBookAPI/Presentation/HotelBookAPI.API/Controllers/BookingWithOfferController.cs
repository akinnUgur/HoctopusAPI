using HotelBookAPI.Application.Features.Booking.WithOffer;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers

{ 

      [Route("api/[controller]")]
      [ApiController]

    public class BookingWithOfferController : BaseApiController
    {
      
            [HttpPost("BookWithOffer")]

            public async Task<IActionResult> BookWithOffer([FromBody] BeginTransactionWithOfferRequest request)
            {
                var data = await Mediator.Send(request);

                return Ok(data);
            }
        
    }
}
