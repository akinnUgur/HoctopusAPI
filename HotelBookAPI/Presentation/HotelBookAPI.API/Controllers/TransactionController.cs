using HotelBookAPI.Application.Features.CommitTransaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : BaseApiController
    {

        [HttpPost("CommitTransaction")]
        public async Task<IActionResult> CommitTransaction(CommitTransactionRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
