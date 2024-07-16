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
        public int TravellerId { get; set; }

        public List<availableTitles> availableTitle {  get; set; }

        public AcademicTitle academicTitle { get; set; }

        public List<availableAcademicTitles> availableAcademicTitle { get; set; }

        public bool TravllersisLeader {  get; set; }

        public string birthDate { get; set; }

        public Nationality nationality { get; set; }

        public string identityNumber { get; set; }

        public TravellerPassportInfo travellerPassportInfo { get; set; }

        public TravellerAddressInfo travellerAddressInfo { get; set; }

        public List<TravellersServices> TravellersService {  get; set; }

        public int orderNumber { get; set; }

        public string birthDateFrom { get; set; }

        public string birthDateTo { get; set; }

        public List<string> requiredFields { get; set; }

        public List<AdditionalFields> additionalField { get; set; }

    }
    public class availableTitles 
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class AcademicTitle 
    {
        public string id { get; set; }
    }
    public class availableAcademicTitles 
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Nationality 
    {
        public string twoLetterCode { get; set; }
    }

    public class TravellerPassportInfo 
    {
        public string expireDate { get; set; }
        public string issueDate { get; set; }
        public string citizenshipCountryCode { get; set; }
    }

    public class TravellerAddressInfo 
    {
        public TravellerContactPhone travellercontactPhone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
            
        public string zipCode { get; set; }

        public TravellerCity travellerCity { get; set; }

        public TravellerCountry travellerCountry { get; set; }

    }
    public class TravellerContactPhone {}
    public class TravellerCity 
    {
        public string id { get; set; }
        public string name { get; set; }

    }
    public class TravellerCountry
    {
        public string id { get; set; }
        public string name { get; set; }

    }
    public class TravellersServices 
    {
        public string id { get; set; }

        public int type { get; set; }

        public tPrice tprice{ get; set; }

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

    }
    public class AddServicesPaymentPlan 
    {
        public int paymentNo { get; set; }

        public string dueDate { get; set; }

        public AddServicesPaymentPlanPrice addServicesPaymentPlanPrice {  get; set; } 

        public bool paymentStatus { get; set; }
        
    }

    public class AddServicesPaymentPlanPrice
    {
        public int percent { get; set; }
        
        public int amount { get; set; }

        public string currency { get; set; }

        
        
    }
}
