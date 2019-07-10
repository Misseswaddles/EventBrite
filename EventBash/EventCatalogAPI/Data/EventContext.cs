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
        //this will be added after we update the config file, and will make the clas injectable
        public EventContext(DbContextOptions options) : base(options)
        {
            //this is empty but needs to be filled shortly.
        }
       

        public DbSet<EventCategory> EventCategories { get; set; } // EventCategories is the table

        public DbSet<EventVenue> EventVenues { get; set; } // EventVenues is the table

        public DbSet<EventStartDate> EventStartDates { get; set; }


        //below it would be a best practice to change EventItems to EventItem
        //Selvi - Updated the folder name under Domains to EventItem and the below table name to EventItems as mentioned in class as a good practice
        public DbSet<EventItem> EventItems { get; set; } //note, this should be edited ---> Update done by Selvi



        //Ceate the primary keys for Entity Framework
        protected override void OnModelCreating(ModelBuilder modelBuilder )

        //The EventSeed file will create a method to get 
        //ex. ConfigureEventVenue, etc.
        {
            modelBuilder.Entity<EventVenue>(ConfigureEventVenue);
            modelBuilder.Entity<EventCategory>(ConfigureEventCategory);
            modelBuilder.Entity<EventItem>(ConfigureEventItem); //Selvi -> updated ConfigureEventItems to ConfigureEventItem to make it more sensible 
            modelBuilder.Entity<EventStartDate>(ConfigurEventStartDates);
        }



        private void ConfigureEventItem(EntityTypeBuilder<EventItem> builder)
        {
            builder.ToTable("Events");//the actual name of the event catalog
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("events_hilo");

            builder.Property(c => c.EventName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.EventCost) // Selvi -> have declared a property as EventCost. Check it out
                .IsRequired();

            //Here, are the relationships between Events and the venue and category
            builder.HasOne(c => c.EventCategory) //red will go away when Items is successfully entered
                .WithMany()
                .HasForeignKey(c => c.EventCategoryId);

            builder.HasOne(c => c.EventVenue) //red will go away when Items is successfully entered
                .WithMany()
                .HasForeignKey(c => c.EventVenueId);

            builder.HasOne(c => c.EventStartDate)
                .WithMany()
                .HasForeignKey(c => c.EventStartDateId);

            
        }

        private void ConfigurEventStartDates(EntityTypeBuilder<EventStartDate> builder)
        {
            builder.ToTable("EventStartDates");

            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("event_start_date_hilo");

            builder.Property(c => c.StartDate)
                .IsRequired()
                .HasMaxLength(50);
        }

        private void ConfigureEventCategory(EntityTypeBuilder<EventCategory> builder)
        {
            builder.ToTable("EventCategories");

            builder.Property(c => c.Id)
                .IsRequired() //primary key
                .ForSqlServerUseSequenceHiLo("event_category_hilo"); //

            builder.Property(c => c.Category) //would be good to change type member to category.
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
