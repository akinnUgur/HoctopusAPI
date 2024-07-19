using AutoMapper.Internal.Mappers;
using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.DTOs.Common;
using HotelBookAPI.Application.Features.PriceSearch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Booking.WithOffer
{
    public class BeginTransactionResponse
    {
        public Header Header { get; set; }
        public BookWithOfferBody? Body { get; set; }

    }




    public class BookWithOfferBody
    {

        public string TransactionId { get; set; }

        public DateTime ExpiresOn { get; set; }

        public ReservationData ReservationData { get; set; }

        public int Status { get; set; }

        public int TransactionType { get; set; }


    }

    public class ReservationData
    {
        public List<Traveller> Travellers { get; set; }
        public ReservationInfo ReservationInfo { get; set; }

        public List<Service> Services { get; set; }

        public PaymentDetail PaymentDetail { get; set; }

        

    }

    public class Traveller
    {
        public string TravellerId { get; set; }
        public int Type { get; set; }

        public int Title { get; set; }

        public bool IsLeader { get; set; }

        public DateTime BirthDate { get; set; }

        public Nationality Nationality { get; set; }

        public string IdentityNumber { get; set; }

        public PassportInfo PassportInfo { get; set; }


      //  public List<Service> Services { get; set; }

        public int OrderNumber { get; set; }



        public List<string> RequiredFields { get; set; }



        public int PassengerType { get; set; }







    }

    public class AcademicTitle
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ReservationInfo
    {
        public string BookingNumber { get; set; }

        public Agency Agency { get; set; }


        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

      

        public Price SalePrice { get; set; }

        public Price SupplementDiscount { get; set; }

        public Price PassengerEB { get; set; }

        public Price AgencyEB { get; set; }

        public Price PassengerAmountToPay { get; set; }

        public Price AgencyAmountToPay { get; set; }

        public Price Discount { get; set; }


        public Price AgencyBalance { get; set; }

        public Price PassengerBalance { get; set; }

        public Commission AgencyCommission { get; set; }

        public Commission BrokerCommission { get; set; }


        public Commission AgencySupplementCommission { get; set; }


        public Price PromotionAmount { get; set; }


        public Price PriceToPay { get; set; }


        public Price AgencyPriceToPay { get; set; }


        public Price PassengerPriceToPay { get; set; }


        public Price TotalPrice { get; set; }

        public int ReservationStatus { get; set; }

        public int ConfirmationStatus { get; set; }

        public int PaymentStatus { get; set; }

        public List<object> Documents { get; set; }

        public List<object> OtherDocuments { get; set; }

        public ReservableInfo ReservableInfo { get; set; }

        public int PaymentFrom { get; set; }

        public DepartureCountry DepartureCountry { get; set; }

        public DepartureCity DepartureCity { get; set; }

        public ArrivalCountry ArrivalCountry { get; set; }

        public ArrivalCity ArrivalCity { get; set; }

        public DateTime CreateDate { get; set; }

        public AdditionalField AdditionalField { get; set; }




        public double AgencyDiscount { get; set; }


        public bool HasAvailablePromotionCode { get; set; }
    }


    public class ReservationAdditionalField
    {
        public string SmsLimit { get; set; }

        public string PriceChanged { get; set; }

        public string AllowSalePriceEdit { get; set; }

        public string SendFlightSms { get; set; }

    }

    public class DepartureCountry
    {
        public string Code { get; set; }
        public string InternationalCode { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string ParentId { get; set; }

        public string CountryId { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public int Id { get; set; }


    }


    public class DepartureCity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string ParentId { get; set; }

        public string CountryId { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public int Id { get; set; }
    }

    public class ArrivalCountry
    {
        public string Code { get; set; }
        public string InternationalCode { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string ParentId { get; set; }

        public string CountryId { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public int Id { get; set; }

    }


    public class ArrivalCity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string ParentId { get; set; }

        public string CountryId { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public int Id { get; set; }
    }

    public class Agency
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool OwnAgency { get; set; }

        public Country Country { get; set; }    

        public Address Address { get; set; }

        public bool AceExport { get; set; }
    }

    public class AgencyUser
    {
        public Office Office { get; set; }

        public Operator Operator { get; set; }

        public Market Market { get; set; }

        public UserAgency UserAgency { get; set; }

        public string Name { get; set; }

        public string Code { set; get; }

    }

    public class UserAgency
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool OwnAgency { get; set; }

        public bool AceExport { get; set; }
    }

    public class Office
    {
        public string Code { get; set; }

        public string Name { set; get; }
    }

    public class Operator
    {
        public string Code { get; set; }

        public string Name { set; get; }

        public bool AgencyCanDiscountCommission { get; set; }
    }

    public class Market
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }

    public class Commission
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public string Currency {  get; set; }
    }
    public class AdditionalField
    {
        public string TravellerTypeOrder { get; set; }

        public string TravellerUniqueID { get; set; }

        public string TourVisio_TravellerId { get; set; }

        public string Paximum_TravellerId { get; set; }

        public DateTime BirthDateFrom { get; set; }

        public DateTime BirthDateTo { get; set; }

        public string IsRefundable { set; get; }
        public string ReservableInfo { set; get; }

        public string IsEditable { set; get; }
    }


    public class Service
    {

        public int OrderNumber { get; set; }
        public string Note { get; set; }



        public string PartnerServiceId { get; set; }

        public bool IsMainService { get; set; }

        public bool IsRefundable { get; set; }

        public bool Bundle { get; set; }

        public List<CancellationPolicy> CancellationPolicies { get; set; }


        public string EncryptedServiceNumber { get; set; }


        public decimal Commission { get; set; }


        public int Unit { get; set; }


        public int ConfirmationStatus { get; set; }

        public int ServiceStatus { get; set; }


        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Adult { get; set; }

        public int Child { get; set; }

        public int Infant { get; set; }

        public Price Price { get; set; }

        public bool IncludePackage { get; set; }

        public bool Compulsory { get; set; }

        public bool IsExtraService { get; set; }

        public int Provider { get; set; }

        public List<string> Travellers { get; set; }

        public bool ThirdPartyRecord { get; set; }

        public int RecordId { get; set; }

        public AdditionalField AdditionalField { get; set; }




    }

    public class Price
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
    public class DestinationAddress
    {

    }

    public class Address
    {
        public ContactPhone ContactPhone { get; set; }
        public string Email { get; set; }

        public string AddressText { get; set; }

        public string ZipCode { get; set; }

        public City City { get; set; }

        public TransactionCountry Country { get; set; }

    }

    public class TransactionCountry
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int Provider {  get; set; }

        public bool IsTopRegion { get; set; }
    }
    public class ContactPhone
    {
        public string Phone { get; set; }
    }

    public class PassportInfo
    {

        public DateTime ExpireDate { get; set; }

        public DateTime IssueDate { get; set; }

        public string CitizenshipCountryCode { get; set; }
    }

    public class Nationality
    {
        public string TwoLetterCode { get; set; }
    }
    public class Title
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
    public class ReservableInfo
    {
        public bool Reservable { get; set; }
    }

    public class PaymentDetail
    {
        public List<PaymentPlan> PaymentPlan { get; set; }
    }

    public class PaymentPlan
    {
        public int PaymentNo { get; set; }
        public DateTime DueDate { get; set; }
        public Price Price { get; set; }
        public bool PaymentStatus { get; set; }
    }

    public class ServiceDetails
    {
        public string ServiceId { get; set; }
        public string Thumbnail { get; set; }
        public HotelDetail HotelDetail { get; set; }
        public int Night { get; set; }
        public string Room { get; set; }
        public string Board { get; set; }
        public string Accom { get; set; }
        public GeoLocation GeoLocation { get; set; }
    }

    public class GeoLocation
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }

    public class CancellationPolicy
    {
        public DateTime BeginDate { get; set; }

        public DateTime DueDate { get; set; }

        public Price Price { get; set; }

        public int Provider {  get; set; }
    }

    public class HotelDetail
    {
        public Address Address { get; set; }
        public Location TransferLocation { get; set; }
        public int StopSaleGuaranteed { get; set; }
        public int StopSaleStandart { get; set; }
        public GeoLocation Geolocation { get; set; }
        public Location Location { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string Thumbnail { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Location
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ParentId { get; set; }
        public string CountryId { get; set; }
        public int Provider { get; set; }
        public bool IsTopRegion { get; set; }
        public string Id { get; set; }
    }


}



