﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common
{
    public class RoomCriteria
    {
        public int Adult { get; set; }
        public List<int>? ChildAges { get; set; }

    }
}
