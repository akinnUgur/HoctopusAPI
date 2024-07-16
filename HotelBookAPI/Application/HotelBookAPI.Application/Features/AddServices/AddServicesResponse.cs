using HotelBookAPI.Application.Features.ProductInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelBookAPI.Application.Features.AddServices
{
    public class AddServicesResponse
    {
        public AddServicesHeader Header { get; set; }

        public AddServicesBody? Body { get; set; }
    }

    public class AddServicesHeader 
    {
        public string RequestId { get; set; }
        public bool Success { get; set; }
        public List<AddServicesInfoMessages> Messages { get; set; }
    }

    public class AddServicesInfoMessages 
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
    public class AddServicesBody 
    {
        public string TransactionId { get; set; }

        public string ExpiresOn { get; set; }

        public AddServicesReservationData ReservationData { get; set; }

    }
    public class AddServicesReservationData 
    {
        public List<AddServicesTravellers> Travellers { get; set; }

        public AddServicesReservationInfo ReservationInfo { get; set; }

        public List<AddServicesServices> Services { get; set; }

        public AddServicesPaymentDetail PaymentDetail { get; set; }


    }
    public class AddServicesTravellers 
    {

    }
    public class AddServicesReservationInfo 
    {

    }
    public class AddServicesServices 
    {

    }
    public class AddServicesPaymentDetail 
    {
        public List<AddServicesPaymentPlan> PaymentPlan { get; set; }

    }
    public class AddServicesPaymentPlan 
    {
        
    }
}
