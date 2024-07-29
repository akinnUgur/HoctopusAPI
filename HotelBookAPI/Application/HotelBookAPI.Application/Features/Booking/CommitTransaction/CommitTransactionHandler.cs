using AutoMapper;
using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.CommitTransaction
{
    public class CommitTransactionHandler : CommonHandler, IRequestHandler<CommitTransactionRequest, CommitTransactionResponse>
    {
        private readonly IEmailService _emailService;

        private readonly ITransactionService _transactionService;
        public CommitTransactionHandler(IMapper mapper, ITransactionService transactionService, IEmailService emailService) : base(mapper)
        {
            _transactionService = transactionService;
            _emailService = emailService;
        }

        public async Task<CommitTransactionResponse> Handle(CommitTransactionRequest request, CancellationToken cancellationToken)
        {
            var result = await _transactionService.CommitTransactionAsync(request, cancellationToken);
            if(result.Header.Success)
            {
                var emailBody = $@"
                <!DOCTYPE html>
                    <html>
<head>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }}
        .container {{
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }}
        .header {{
            text-align: center;
            padding-bottom: 20px;
        }}
        .header img {{
            width: 100px;
        }}
        .content {{
            text-align: left;
        }}
        .footer {{
            text-align: center;
            padding-top: 20px;
            color: #888888;
            font-size: 12px;
        }}
        .button {{
            display: inline-block;
            padding: 10px 20px;
            margin-top: 20px;
            background-color: #FF7F00;
            color: #ffffff;
            text-decoration: none;
            border-radius: 5px;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h1>Thanks for using Hoctopus :))</h1>
        </div>
        <div class='content'>
            <p>Hello,</p>
            <p>Your reservation number is: <strong>{result.Body.ReservationNumber}</strong></p>
            <p>We appreciate your business and hope you enjoy our service!</p>
            <p>If you have any questions, feel free to contact us.</p>
            <a href='http://www.hoctopus.com' class='button'>Visit Our Website</a>
        </div>
        <div class='footer'>
            <p>&copy; 2024 Hoctopus. All rights reserved.</p>
        </div>
    </div>
</body>
</html>";

                _emailService.SendEmail(new()
                {
                    Body = emailBody,
                    Subject = "Thanks for using Hoctopus",
                    To = request.Email
                });
            }

            return result;
        }
    }
}
