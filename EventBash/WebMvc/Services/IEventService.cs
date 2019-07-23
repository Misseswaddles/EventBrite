using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    interface IEventService
    {
        Task<Event> GetEventItemsAsync(int page, int size,
                int? category, int? venue);
    }
}
