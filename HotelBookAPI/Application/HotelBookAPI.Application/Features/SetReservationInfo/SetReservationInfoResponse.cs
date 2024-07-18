using HotelBookAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.SetReservationInfo
{
    public class SetReservationInfoResponse
    {
        public Header Header{ get; set; }
        public SetReservationInfoBody? Body { get; set; }

    }
    public class SetReservationInfoBody
    {
        public string TransactionId { get; set; }
        public string ExpiresOn { get; set; }

        public int Status { get; set; }
        public int TransactionType { get; set; }

        public ReservationData ReservationData { get; set; }

    }

    public class ReservationData
    {
        public List<Traveller> Travellers { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
    }

    public class ReservationInfo
    {
        public string BookingNumber { get; set; }
        //public Agency Agency { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string Note { get; set; }
        public string AgencyReservationNumber { get; set; }
        public Price SalePrice { get; set; }
        public Price SupplementDiscount { get; set; }
        //public Price PassengerEB { get; set; }
        //public Price AgencyEB { get; set; }
        //public Price PassengerAmountToPay { get; set; }
        //public Price AgencyAmountToPay { get; set; }
        //public Price Discount { get; set; }
        //public Price AgencyBalance { get; set; }
        //public Price PassengerBalance { get; set; }
        //public Commission AgencyCommission{ get; set; }
        //public Commission BrokerCommission { get; set; }
        //public Commission AgencySupplementCommission { get; set; }
        //public Price PriceToPay { get; set; }
        public Price AgencyPriceToPay { get; set; }
        public Price PassengerPriceToPay { get; set; }
        public Price TotalPrice { get; set; }

        public int ReservationStatus { get; set; }
        public int ConfirmationStatus { get; set; }
        public int PaymentStatus { get; set; }


    }
    public class Agency
    {
        public string Code { get; set; }
        public string Name { get; set; }
    
    }

    public class Commission
    {
        public int Percent { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }

    }
}
