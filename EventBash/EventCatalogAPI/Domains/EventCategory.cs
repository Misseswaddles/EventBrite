using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domains
{
    public class EventCategory //Analagous to Catatlog Typed
    {


        //This is tied to EventVenue and EventCategory
        public int EventCategoryId { get; set; } //foregin key


        public int EventVenueId { get; set; } //foreign key
        public string Category { get; set; }
    }
}
