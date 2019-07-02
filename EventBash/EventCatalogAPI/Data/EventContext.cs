using EventCatalogAPI.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventContext : DbContext 
    {
        /* this will be added after we update the config file, and will make the clas injectable
        public EventContext(DbContextOptions options) : base(options)
        {

        }
        */

        public DbSet<EventCategory> EventCategories { get; set; }

        public DbSet<EventVenue> EventVenues { get; set; }


        //below it would be a best practice to change EventItems to EventItem
        public DbSet<EventItems> EventItem { get; set; } //note, this should be edited

    }
}
