using HotelBookAPI.Application.Features.AddServices;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using HotelBookAPI.Application.Features.CommitTransaction;
using HotelBookAPI.Application.Features.GetReservationDetails;
using HotelBookAPI.Application.Features.RemoveServices;
using HotelBookAPI.Application.Features.SetReservationInfo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseApiController
    {
        [HttpPost("BookWithOffer")]
        public async Task<IActionResult> BookWithOffer([FromBody] BeginTransactionWithOfferRequest request)
        {
            var data = await Mediator.Send(request);

            return Ok(data);
        }

        [HttpPost("AddServices")]
        public async Task<IActionResult> AddServices(AddServicesRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }

        [HttpPost("RemoveServices")]
        public async Task<IActionResult> RemoveServices(RemoveServicesRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }


        [HttpPost("SetReservationInfo")]
        public async Task<IActionResult> SetReservationInfo(SetReservationInfoRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);    
        }


        [HttpPost("CommitTransaction")]
        public async Task<IActionResult> CommitTransaction(CommitTransactionRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }


        [HttpPost("GetReservationDetails")]
        public async Task<IActionResult> GetReservationDetails(GetReservationDetailsRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
