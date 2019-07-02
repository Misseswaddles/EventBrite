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
            builder.ToTable("Events");//the actual name of the event catalog
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("events_hilo");

            builder.Property(c => c.EventName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.EventPrice)
                .IsRequired();

            //Here, are the relationships between Events and the venue and category
            builder.HasOne(c => c.EventCategory) //red will go away when Items is successfully entered
                .WithMany()
                .HasForeignKey(c => EventCategoryId);

            builder.HasOne(c => c.EventVenue) //red will go away when Items is successfully entered
                .withMany()
                .HasForeignKey(c => EventVenueId);

            
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
