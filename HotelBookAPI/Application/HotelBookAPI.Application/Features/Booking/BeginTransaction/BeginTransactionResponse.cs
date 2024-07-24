using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.DTOs.Common.HotelDatas;
using HotelBookAPI.Application.Features.Booking.AddServices;


namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionResponse
    {
        public required Header Header { get; set; }
        public BeginTransactionBody? Body { get; set; }

    }




    public class BeginTransactionBody
    {

     

    }

}



