using AutoMapper.Internal.Mappers;
using HotelBookAPI.Application.DTOs.AutoComplete;
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

        public Body Body { get; set; }
    }

    public class Header
    {
        public string RequestID { get; set; }
        public bool Success { get; set; }
        public DateTime ResponseTime { get; set; }

        public List<Message> Messages { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public int MessageType { get; set; }

        public string MessageText { get; set; }

    }

    public class Body
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

        public List<Invoice> Invoices { get; set; }
    }

    public class Traveller
    {
        public int TravellerId { get; set; }
        public int Type { get; set; }

        public int Title { get; set; }

        public List<Title> AvailableTitles { get; set; }

        public List<Title> AvailableAcademicTitles { get; set; }

        public bool IsLeader { get; set; }

        public DateTime BirthDate { get; set; }

        public Nationality Nationality { get; set; }

        public string IdentityNumber { get; set; }

        public PassportInfo PassportInfo { get; set; }

        public Address Adress { get; set; }

        //????
        public DestinationAddress DestinationAddress { get; set; }

        public List<Service> Services { get; set; }

        public int OrderNumber { get; set; }

        public DateTime BirthDateFrom { get; set; }

        public DateTime BirthDateTo { get; set; }


        //?????? string?
        public List<object> RequiredFields { get; set; }


        public List<object> Documents { get; set; }

        public int PassengerType { get; set; }

        public AdditionalField AdditionalFields { get; set; }

        public List<object> InsertFields { get; set; }

        public int Status { get; set; }


    }

    public class ReservationInfo
    {
        public string BookingNumber { get; set; }

        public Agency Agency { get; set; }

        public AgencyUser AgencyUser { get; set; }

        //SİL???
        public ReservationInfoAgencyCountry ReservationInfoCountry { get; set; }

        //sil????
        public ReservationInfoAddress ReservationInfoAddress { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Note { get; set; }

        public Price SalePrice { get; set; }

        public Price SupplementDiscount { get; set; }

        public Price PassengerFB { get; set; }

        public Price AgencyEB { get; set; }

        public Price PassengerAmountToPay { get; set; }

        public Price AgencyAmountToPay { get; set; }

        public Price Discount { get; set; }


        public Price AgencyBalance { get; set; }

        public Price PassengerBalance { get; set; }

        public Price AgencyCommission { get; set; }

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

        public ReservationAdditionalField ReservationAdditionalField { get; set; }

        public string AdditionalCode1 { get; set; }


        public string AdditionalCode2 { get; set; }


        public string AdditionalCode3 { get; set; }


        public string AdditionalCode4 { get; set; }


        public int AgencyDiscount { get; set; }


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

        public bool AceExport { get; set; }
    }

    public class AgencyUser
    {
        public Office Office;

        public Operator Operator;

        public Market Market;

        public UserAgency UserAgency;

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
    public class ReservationInfoAgencyCountry
    {
        public string InternationalCode { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }
    }

    public class ReservationInfoAddress
    {
        public ReservationInfoAddressCountry Country { get; set; }

        public ReservationInfoAddressCity ReservationInfoAddressCity { get; set; }

        //??????
        public List<string> AddressLines { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string AddressText { get; set; }
    }

    public class ReservationInfoAddressCity
    {

        public string City { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public string Id { get; set; }
    }

    public class ReservationInfoAddressCountry
    {
        public string InternationalCode { set; get; }

        public string Name { get; set; }

        public int Provider { set; get; }

        public bool IsTopRegion { set; get; }

        public string Id { get; set; }
    }


    public class AdditionalField
    {
        public string TravellerTypeOrder { get; set; }

        public string TravellerUniqueID { get; set; }

        public string TourVisio_TravellerId { get; set; }

        public string Paximum_TravellerId { get; set; }

        public DateTime BirthDateFrom { get; set; }

        public DateTime BirthDateTo { get; set; }
    }

    public class AdditionalField2
    {
        public string IsRefundable { set; get; }
        public string ReservableInfo { set; get; }

        public string IsEditable { set; get; }
    }


    public class Service
    {

        public int OrderNumber { get; set; }
        public string Note { get; set; }

        public DepartureCountry DepartureCountry { get; set; }

        public DepartureCity DepartureCity { get; set; }
        public ArrivalCountry ArrivalCountry { get; set; }
        public ArrivalCity ArrivalCity { get; set; }

        public ServiceDetails ServiceDetails { get; set; }

        public string PartnerServiceId { get; set; }

        public bool IsMainService { get; set; }

        public bool IsRefundable { get; set; }

        public bool Bundle { get; set; }

        public List<CancellationPolicy> CancellationPolicies { get; set; }

        public List<object> Documents { get; set; }

        public string EncryptedServiceNumber { get; set; }

        public List<object> PriceBreakDowns { get; set; }

        public decimal Commission { get; set; }

        public ReservableInfo ReservableInfo { get; set; }

        public int Unit { get; set; }

        public List<object> ConditionalSpos { get; set; }

        public int ConfirmationStatus { get; set; }

        public int ServiceStatus { get; set; }

        public int ProductType { get; set; }

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

        public List<Traveller> Travellers { get; set; }

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



    public class Commission { }


    //????
    public class ReservableInfo
    {
        public bool Reservable { get; set; }
    }
}



