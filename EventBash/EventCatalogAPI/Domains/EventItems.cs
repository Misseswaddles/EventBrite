using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domains
{
    public class EventItems
    {



        //This is tied to  and EventCategory (like Catalog Type
        public int EventCategoryId { get; set; } //foregin key

        public virtual

        //this is tied to EventVenue
        public int EventVenueId
        { get; set; } //foreign key

    }
}
