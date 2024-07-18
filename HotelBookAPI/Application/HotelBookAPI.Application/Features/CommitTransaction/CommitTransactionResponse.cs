using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.CommitTransaction
{
    public class CommitTransactionResponse
    {
        public Header Header { get; set; }
        public CommitTransactionBody? Body { get; set; }

    }

    public class CommitTransactionBody
    {
        public string ReservationNumber { get; set; }
        public string EncryptedReservationNumber { get; set; }
        public string TransactionId { get; set; }

    }

}
