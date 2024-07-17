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

        public int Status { get; set; }

        public int TransactionType { get; set; }

    }
    public class AddServicesReservationData
    {
        public List<AddServicesTravellers> Travellers { get; set; }

        public AddServicesReservationInfo ReservationInfo { get; set; }

        public List<AddServicesServices> Services { get; set; }

        public AddServicesPaymentDetail PaymentDetail { get; set; }

        public List<AddServicesInvoices> Invoices { get; set; }


    }
    public class AddServicesTravellers
    {
        public string TravellerId { get; set; }

        public int Type { get; set; }

        public int Title { get; set; }

        public List<availableTitle> AvailableTitles { get; set; }

        public AcademicTitle AcademicTitle { get; set; }

        public List<availableAcademicTitle> AvailableAcademicTitles { get; set; }

        public bool IsLeader { get; set; }

        public string BirthDate { get; set; }

        public Nationality Nationality { get; set; }

        public string IdentityNumber { get; set; }

        public TravellerPassportInfo PassportInfo { get; set; }

        public TravellerAddressInfo Address { get; set; }

        public TravellerDestinationAddress DestinationAddress { get; set; }

        public List<TravellersServices> Services { get; set; }

        public int orderNumber { get; set; }

        public string birthDateFrom { get; set; }

        public string birthDateTo { get; set; }

        public List<string> requiredFields { get; set; }

        public List<AdditionalFields> additionalField { get; set; }

    }
    public class availableTitle
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class AcademicTitle
    {
        public string Id { get; set; }
    }
    public class availableAcademicTitle
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Nationality
    {
        public string TwoLetterCode { get; set; }
    }

    public class TravellerPassportInfo
    {
        public string ExpireDate { get; set; }
        public string IssueDate { get; set; }
        public string CitizenshipCountryCode { get; set; }
    }

    public class TravellerAddressInfo
    {
        public TravellerContactPhone ContactPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string ZipCode { get; set; }

        public TravellerCity City { get; set; }

        public TravellerCountry Country { get; set; }

    }
    public class TravellerContactPhone { }
    public class TravellerCity
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
    public class TravellerCountry
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
    public class TravellerDestinationAddress { }
    public class TravellersServices
    {
        public string Id { get; set; }

        public int Type { get; set; }

        public tPrice Price { get; set; }

        public int passengerType { get; set; }

    }
    public class tPrice
    {
        public int amount { get; set; }

        public string currency { get; set; }

    }

    public class AdditionalFields
    {
        public string travellerTypeOrder { get; set; }
        public string travellerUniqueID { get; set; }
        public string tourVisio_TravellerId { get; set; }
        public string paximum_TravellerId { get; set; }
        public string birthDateFrom { get; set; }
        public string birthDateTo { get; set; }

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

        public List<AddServicesPaymentInfo> PaymentInfo { get; set; }

    }
    public class AddServicesPaymentPlan
    {
        public int PaymentNo { get; set; }

        public string DueDate { get; set; }

        public AddServicesPaymentPlanPrice PaymentPlan { get; set; }

        public bool PaymentStatus { get; set; }

    }

    public class AddServicesPaymentPlanPrice
    {
        public int Percent { get; set; }

        public int Amount { get; set; }

        public string Currency { get; set; }



    }
    
    
    
    
    
    
    
    public class AddServicesPaymentInfo {}

    public class AddServicesInvoices{}
}
