using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    //0	:	travellerId
    //1	:	type
    //2	:	title
    //3	:	name
    //4	:	surname
    //5	:	isleader
    //6	:	birthDate
    //7	:	leaderEmail
    //8	:	nationality


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
        public required string TravellerId { get; set; }
        public int Type { get; set; }

        public int Title { get; set; }

        public bool IsLeader { get; set; }

        public DateTime BirthDate { get; set; }

        public required Nationality Nationality { get; set; }

        public required string IdentityNumber { get; set; }

        public required PassportInfo PassportInfo { get; set; }


        //  public List<Service> Services { get; set; }

        public int OrderNumber { get; set; }

       // public required List<string> RequiredFields { get; set; }

        public int PassengerType { get; set; }
    }
}
