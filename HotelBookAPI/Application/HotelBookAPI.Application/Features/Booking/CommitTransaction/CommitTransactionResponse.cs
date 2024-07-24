using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.CommitTransaction
{
    public class CommitTransactionResponse
    {
        public required Header Header { get; set; }

        public CommitTransactionBody? Body { get; set; }

    }

    public class CommitTransactionBody
    {
        public required string ReservationNumber { get; set; }
        public required string EncryptedReservationNumber { get; set; }
        public required string TransactionId { get; set; }

    }

}
