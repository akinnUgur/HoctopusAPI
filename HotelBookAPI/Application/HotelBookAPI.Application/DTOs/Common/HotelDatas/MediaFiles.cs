﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookAPI.Application.DTOs.Common.HotelDatas
{
    public class MediaFiles
    {
        public int? FileType { get; set; }
        public required string UrlFull { get; set; }
    }
}
