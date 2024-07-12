﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ObjectResult ReturnResult<T>(Response<T> response)
        {
            return response.Succeeded ? Ok(response) : BadRequest(response);
        }
    }
}
