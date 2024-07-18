using HotelBookAPI.Application.Features.GetReservationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.GetReservationDetails
{
    public class GetReservationDetailsResponse
    {
        public GetReservationDetailHeader Header { get; set; }

        public GetReservationDetailBody? Body { get; set; }
    }
    public class GetReservationDetailHeader
    {
        public string RequestId { get; set; }
        public bool Success { get; set; }
        public List<GetReservationDetailInfoMessages> Messages { get; set; }
    }

    public class GetReservationDetailInfoMessages
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
    public class GetReservationDetailBody
    {
        public string TransactionId { get; set; }

        public string ExpiresOn { get; set; }

        public GetReservationDetailReservationData ReservationData { get; set; }

        public int Status { get; set; }

        //public int TransactionType { get; set; }

    }
    public class GetReservationDetailReservationData
    {
        public List<GetReservationDetailTravellers> Travellers { get; set; }

        public GetReservationDetailReservationInfo ReservationInfo { get; set; }

        public List<GetReservationDetailServices> Services { get; set; }

        public GetReservationDetailPaymentDetail PaymentDetail { get; set; }

        public List<GetReservationDetailInvoices> Invoices { get; set; }


    }
    public class GetReservationDetailTravellers
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

        public int OrderNumber { get; set; }

        public string BirthDateFrom { get; set; }

        public string BirthDateTo { get; set; }

        public List<string> RequiredFields { get; set; }

        public List<Document> Documents { get; set; }

        public int PassengerType { get; set; }

        public List<AdditionalField> AdditionalFields { get; set; }

        public List<InsertField> InsertFields { get; set; }

        public int Status { get; set; }

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

        public TravellerCityandCountry City { get; set; }

        public TravellerCityandCountry Country { get; set; }

    }
    public class TravellerContactPhone { }
    public class TravellerCityandCountry
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

        public int PassengerType { get; set; }

    }
    public class tPrice
    {
        public double Amount { get; set; }

        public string Currency { get; set; }

    }

    public class Document { }

    public class AdditionalField
    {
        public string TravellerTypeOrder { get; set; }
        public string TravellerUniqueID { get; set; }
        public string TourVisio_TravellerId { get; set; }
        public string Paximum_TravellerId { get; set; }
        public string BirthDateFrom { get; set; }
        public string BirthDateTo { get; set; }

    }
    public class InsertField { }

    public class GetReservationDetailReservationInfo
    {
        public string BookingNumber { get; set; }

        public GetReservationDetailAgency Agency { get; set; }

        public GetReservationDetailAgencyUser AgencyUser { get; set; }

        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string Note { get; set; }

        public PriceInfo SalePrice { get; set; }
        public PriceInfo SupplementDiscount { get; set; }
        public PriceInfo PassengerEB { get; set; }
        public PriceInfo AgencyEB { get; set; }
        public PriceInfo PassengerAmountToPay { get; set; }
        public PriceInfo AgencyAmountToPay { get; set; }
        public PriceInfo Discount { get; set; }
        public PriceInfo AgencyBalance { get; set; }
        public PriceInfo PassengerBalance { get; set; }
        public CommissionInfo agencyCommission { get; set; }
        public CommissionInfo brokerCommission { get; set; }
        public CommissionInfo AgencySupplementCommission { get; set; }
        public PriceInfo PromotionAmount { get; set; }
        public PriceInfo PriceToPay { get; set; }
        public PriceInfo AgencyPriceToPay { get; set; }
        public PriceInfo PassengerPriceToPay { get; set; }
        public PriceInfo TotalPrice { get; set; }
        public int ReservationStatus { get; set; }
        public int ConfirmationStatus { get; set; }
        public int PaymentStatus { get; set; }

        public List<Document> Documents { get; set; }
        public List<Document> OtherDocuments { get; set; }

        public ReservableInfos ReservableInfo { get; set; }
        public int PaymentFrom { get; set; }

        public CountryInfo DepartureCountry { get; set; }
        public CountryInfo ArrivalCountry { get; set; }
        public CityInfo DepartureCity { get; set; }
        public CityInfo ArrivalCity { get; set; }
        public string CreateDate { get; set; }
        public AdditionalField AdditionalFields { get; set; }
        public string AdditionalCode1 { get; set; }
        public string AdditionalCode2 { get; set; }
        public string AdditionalCode3 { get; set; }
        public string AdditionalCode4 { get; set; }
        public int AgencyDiscount { get; set; }
        public bool HasAvailablePromotionCode { get; set; }

    }

    public class GetReservationDetailAgency
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public RemoveServiceAgencyCountry Country { get; set; }

        public RemoveServiceAgencyAddress Address { get; set; }

        public bool OwnAgency { get; set; }

        public bool AceExport { get; set; }

    }

    public class RemoveServiceAgencyAddress
    {

        public RemoveServiceAgencyAddressCountry Country { get; set; }

        public RemoveServiceAgencyAddressCity City { get; set; }

        public List<string> AddressLines { get; set; }

        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }

    public class RemoveServiceAgencyCountry
    {
        public string InternationalCode { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

    }
    public class RemoveServiceAgencyAddressCountry
    {
        public string InternationalCode { get; set; }

        public string Name { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public string Id { get; set; }

    }
    public class RemoveServiceAgencyAddressCity
    {

        public string InternationalCode { get; set; }

        public string Name { get; set; }

        public int Provider { get; set; }

        public bool IsTopRegion { get; set; }

        public string Id { get; set; }

    }
    public class GetReservationDetailAgencyUser
    {
        public GetReservationDetailAgencyUserOffice Office { get; set; }
        public GetReservationDetailAgencyUserOperator Operator { get; set; }
        public GetReservationDetailAgencyUserMarket Market { get; set; }
        public GetReservationDetailAgencyUserAgency Agency { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
    }
    public class GetReservationDetailAgencyUserOffice
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class GetReservationDetailAgencyUserOperator
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool AgencyCanDiscountCommission { get; set; }
    }
    public class GetReservationDetailAgencyUserMarket
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class GetReservationDetailAgencyUserAgency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool OwnAgency { get; set; }
        public bool AceExport { get; set; }
    }
    public class PriceInfo
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
    }
    public class CommissionInfo
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }

    }
    public class ReservableInfos
    {
        public bool Reservable { get; set; }
    }
    public class CountryInfo
    {
        public string Code { get; set; }
        public string InternationalCode { get; set; }
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
    public class CityInfo
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
    public class AdditionalFields
    {
        public string SmsLimit { get; set; }
        public string PriceChanged { get; set; }
        public string AllowSalePriceEdit { get; set; }
        public string SendFlightSms { get; set; }
    }
    public class GetReservationDetailServices
    {
        public int OrderNumber { get; set; }
        public string Note { get; set; }
        public CountryInfo DepartureCountry { get; set; }
        public CityInfo DepartureCity { get; set; }
        public CountryInfo ArrivalCountry { get; set; }
        public CityInfo ArrivalCity { get; set; }
        public ServiceDetails ServiceDetails { get; set; }
        public string PartnerServiceId { get; set; }
        public bool IsMainService { get; set; }
        public bool IsRefundable { get; set; }
        public bool Bundle { get; set; }
        public List<CancellationPolicy> CancellationPolicies { get; set; }
        public List<Document> Documents { get; set; }
        public string EncryptedServiceNumber { get; set; }
        public List<PriceBreakDown> PriceBreakDowns { get; set; }
        public int Commission { get; set; }
        public ReservableInfos ReservableInfo { get; set; }
        public int Unit { get; set; }
        public List<ConditionalSpo> ConditionalSpos { get; set; }
        public int ConfirmationStatus { get; set; }
        public int ServiceStatus { get; set; }
        public int ProductType { get; set; }
        public bool CreateServiceTypeIfNotExists { get; set; }
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
        public PriceInfo Price { get; set; }
        public bool IncludePackage { get; set; }
        public bool Compulsory { get; set; }
        public bool IsExtraService { get; set; }
        public int Provider { get; set; }
        public List<string> Travellers { get; set; }
        public bool ThirdPartyRecord { get; set; }
        public int RecordId { get; set; }
        public ServiceAdditionalFields AdditionalFields { get; set; }

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
    public class HotelDetail
    {
        public HotelDetailAddress Address { get; set; }
        public CityInfo TransferLocation { get; set; }
        public int StopSaleGuaranteed { get; set; }
        public int StopSaleStandart { get; set; }
        public GeoLocation Geolocation { get; set; }
        public CityInfo Location { get; set; }
        public CountryInfo Country { get; set; }
        public CityInfo City { get; set; }
        public string Thumbnail { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class HotelDetailAddress
    {
        public List<string> AddressLines { get; set; }

    }

    public class GeoLocation
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }

    public class CancellationPolicy
    {
        public string BeginDate { get; set; }
        public string DueDate { get; set; }
        public PriceInfo Price { get; set; }
        public int Provider { get; set; }
    }
    public class ConditionalSpo { }
    public class ServiceAdditionalFields
    {
        public string IsRefundable { get; set; }
        public string ReservableInfo { get; set; }
        public string IsEditable { get; set; }
    }

    public class GetReservationDetailPaymentDetail
    {
        public List<GetReservationDetailPaymentPlan> PaymentPlan { get; set; }

        public List<GetReservationDetailPaymentInfo> PaymentInfo { get; set; }

    }
    public class GetReservationDetailPaymentPlan
    {
        public int PaymentNo { get; set; }

        public string DueDate { get; set; }

        public GetReservationDetailPaymentPlanPrice Price { get; set; }

        public bool PaymentStatus { get; set; }

    }

    public class GetReservationDetailPaymentPlanPrice
    {
        public int Percent { get; set; }

        public int Amount { get; set; }

        public string Currency { get; set; }



    }






    public class PriceBreakDown { }
    public class GetReservationDetailPaymentInfo { }

    public class GetReservationDetailInvoices { }
}
