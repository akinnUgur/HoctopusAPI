using HotelBookAPI.Application.Features.ProductInfo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoController : BaseApiController
    {

        [HttpPost("GetProductInfo")]
        public async Task<IActionResult> GetProductInfo(ProductInfoRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
