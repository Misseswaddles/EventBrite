using EventCatalogAPI.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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


        //Ceate the primary keys for Entity Framework
        protected override void OnModelCreating(ModelBuilder modelBuilder )

        //The EventSeed file will create a method to get 
        //ex. ConfigureEventVenue, etc.
        {
            modelBuilder.Entity<EventVenue>(ConfigureEventVenue);
            modelBuilder.Entity<EventCategory>(ConfigureEventCategory);
            modelBuilder.Entity<EventItems>(ConfigureEventItems);
        }

        private void ConfigureEventItems(EntityTypeBuilder<EventItems> builder)
        {
            builder.ToTable("EventCatalog");//the actual name of the event catalog
            builder.Property(c => c.Id)
            
        }

        private void ConfigureEventCategory(EntityTypeBuilder<EventCategory> builder)
        {
            builder.ToTable("EventCategories");

            builder.Property(c => c.Id)
                .IsRequired() //primary key
                .ForSqlServerUseSequenceHiLo("event_category_hilo"); //

            builder.Property(c => c.Type) //would be good to change type member to category.
                .IsRequired()
                .HasMaxLength(100);
        }

        private void ConfigureEventVenue(EntityTypeBuilder<EventVenue> builder)
        {
            builder.ToTable("EventVenues");

            builder.Property(c => c.Id) //What to do with the properties
                .IsRequired() //required because Id is the primary key
                .ForSqlServerUseSequenceHiLo("event_venue_hilo");

            builder.Property(c => c.Venue)
                .IsRequired()
                .HasMaxLength(100);
        }


    }
}
