using AutoMapper;

using HotelBookAPI.Application.Features.Common;
using HotelBookAPI.Application.Interfaces;
using MediatR;


namespace HotelBookAPI.Application.Features.Booking.GetReservationDetails
{
    public class GetReservationDetailsHandler : CommonHandler, IRequestHandler<GetReservationDetailsRequest, GetReservationDetailsResponse>
    {
        public readonly IGetReservationDetailsService _getReservationDetailsService;

        public GetReservationDetailsHandler(IMapper mapper, IGetReservationDetailsService getReservationDetailsService) : base(mapper)
        {
            _getReservationDetailsService = getReservationDetailsService;
        }

        public Task<GetReservationDetailsResponse> Handle(GetReservationDetailsRequest request, CancellationToken cancellationToken)
        {
            return _getReservationDetailsService.GetReservationDetailsAsync(request, cancellationToken);
        }
    }
}
