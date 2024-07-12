using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.Features.Common
{
    public class CommonHandler
    {
        protected readonly IMapper _mapper;

        public CommonHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
