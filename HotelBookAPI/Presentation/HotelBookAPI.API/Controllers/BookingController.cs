using HotelBookAPI.Application.Features.Booking.AddServices;
using HotelBookAPI.Application.Features.Booking.CommitTransaction;
using HotelBookAPI.Application.Features.Booking.GetReservationDetails;
using HotelBookAPI.Application.Features.Booking.RemoveServices;
using HotelBookAPI.Application.Features.Booking.SetReservationInfo;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseApiController
    {
        [HttpPost("BeginTransaction")]
        public async Task<IActionResult> BookWithOffer([FromBody] BeginTransactionRequest request)
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
