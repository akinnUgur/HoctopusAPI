using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.BusinessModels
{
    public enum TourVisioServices
    {
        [Description("authenticationservice/login")]
        Authanticate,
        [Description("productservice/getarrivalautocomplete")]
        AutoComplete,
        [Description("productservice/pricesearch")]
        PriceSearch,
        [Description("productservice/getproductinfo")]
        ProductInfo,
        [Description("productservice/getoffers")]
        GetOffers,
        [Description("productservice/getofferdetails")]
        GetOfferDetails,

        [Description("bookingservice/begintransaction")]
        BeginTransaction,
        [Description("bookingservice/addservices")]
        AddServices,
        [Description("bookingservice/removeservices")]
        RemoveServices,
        [Description("bookingservice/setreservationinfo")]
        SetReservationInfo,
        [Description("bookingservice/committransaction")]
        CommitTransaction,
        [Description("bookingservice/getreservationdetail")]
        GetReservationDetails,





    }
}
