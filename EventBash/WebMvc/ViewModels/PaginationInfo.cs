﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.ViewModels
{
    //pagination info for the view model
    public class PaginationInfo
    {
        public long TotalItems { get; set; }

        public long ItemsPerPage { get; set; }

        public int ActualPage { get; set; }

        public int TotalPages { get; set; }

        public string Previous { get; set; }

        public string Next { get; set; }
    }
}
