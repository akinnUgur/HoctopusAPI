using HotelBookAPI.Application.DTOs.Email;
using HotelBookAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HotelBookAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailTest : ControllerBase
    {
        private readonly EmailService _emailService;

        public EmailTest(EmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost("book")]
        public async Task<IActionResult> BookRoom(string email)
        {
            EmailRequest x = new()
            {
                Body = "Denemememmemememmeme",
                Subject = "adaidkşalıhduılakoahduıok",
                To = email

            };
            _emailService.SendEmail(x);


            return Ok();
        }
    }
}
