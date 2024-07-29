using HotelBookAPI.Application.DTOs.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendEmail(EmailRequest request);
    }
}
