using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class EventIndexViewModel
    {
        public PaginationInfo PaginationInfo { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        public IEnumerable<SelectListItem> Venues { get; set; }

        public IEnumerable<EventItem> EventItems { get; set; }

        public int? category { get; set; }

        public int? venue { get; set; }
    }
}
