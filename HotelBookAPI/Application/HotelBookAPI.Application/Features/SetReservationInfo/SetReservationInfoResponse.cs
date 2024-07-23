
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.Features.Booking.WithOffer;
using Newtonsoft.Json;

namespace HotelBookAPI.Application.Features.SetReservationInfo
{
    public class SetReservationInfoResponse
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("body")]
        public SetReservationInfoResponseBody? Body{ get; set; }

    }

    public class SetReservationInfoResponseBody
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        public ReservationData ReservationData { get; set; }
    }
    public class ReservationData
    {

        public ReservationInfo ReservationInfo { get; set; }
    }
    public class ReservationInfo
    {
        public string BookingNumber { get; set; }
        public DTOs.Common.Price SalePrice { get; set; }


    }
  
} 
