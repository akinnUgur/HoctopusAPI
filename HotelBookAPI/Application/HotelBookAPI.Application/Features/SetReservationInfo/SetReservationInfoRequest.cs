using HotelBookAPI.Application.DTOs.AutoComplete;
using HotelBookAPI.Application.DTOs.Common.AutoComplete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.SetReservationInfo
{
    public class SetReservationInfoRequest : IRequest<SetReservationInfoResponse>
    {
        public string TransactionId { get; set; }
        public List<Traveller> Travellers { get; set; }

        public string? ReservationNote{ get; set; }
        public string? AgencyReservationNumber { get; set; }



    }

      //"requiredFields": [
      //      "travellerId",
      //      "type",
      //      "title",
      //      "name",
      //      "surname",
      //      "isleader",
      //      "leaderEmail",
      //      "nationality"
      //    ],
    
    public class Traveller
    {
        public string TravellerId { get; set; }
        public int Type { get; set; }
        public int Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsLeader { get; set; }
        public Nationality Nationality{ get; set; }

        public string? IdentityNumber { get; set; }
        public PassportInfo? PassportInfo { get; set; }
        public Addres Address { get; set; }


    }

    public class AcademicTitle
    {
        public int? Id { get; set; }
    }
    public class Nationality
    {
        public string? TwoLetterCode { get; set; }

    }
    public class PassportInfo
    {
        public string? Serial { get; set; }
        public string? Number { get; set; }
        public string? ExpireDate { get; set; }
        public string? IssueDate { get; set; }
        public string? CitizenshipCountryCode { get; set; }
      

    }

    public class Addres
    {
        public string? email { get; set; }
    }

    public class ContactPhone
    {
        public string? CountryCode { get; set; }
        public string? AreaCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
