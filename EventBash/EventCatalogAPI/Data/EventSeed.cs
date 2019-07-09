using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Domains;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext context)
        {
            //context.Database.Migrate(); //Not yet ready until Events API is completed.

            //Only fill up the database if you don't have anything in there.
            if (!context.EventVenues.Any())
            {
                context.EventVenues.AddRange(GetPreconfiguredEventVenues());

                context.SaveChanges();
            }

            if (!context.EventItems.Any())
            {
               context.EventItems.AddRange(GetPreconfiguredEventItems());

                context.SaveChanges();
            }
            if (!context.EventCategories.Any())
            {
                context.EventCategories.AddRange(GetPreconfiguredEventCategories());

                context.SaveChanges();
            }

            if (!context.EventStartDates.Any())
            {
                context.EventStartDates.AddRange(GetPreconfiguredEventStartDates()) ;

                context.SaveChanges();
            }


        }

        private static IEnumerable<EventStartDate> GetPreconfiguredEventStartDates()
        {
            return new List<EventStartDate>   //This needs to be completed based on the seed data
            {
                new EventStartDate() {StartDate = "11/23/19" },
                new EventStartDate() {StartDate = "7/14/19"},
                new EventStartDate() {StartDate = "8/22/19"},
                new EventStartDate() {StartDate = "7/27/19"},
                new EventStartDate() {StartDate = "8/4/19"},
                new EventStartDate() {StartDate = "9/6/19"}


            };
        }

        private static IEnumerable<EventCategory> GetPreconfiguredEventCategories()
        {
            return new List<EventCategory>
            {
                new EventCategory() {Category = "Music"},
                new EventCategory() {Category = "Food & Drink" },
                new EventCategory() {Category = "Seminars" },
                new EventCategory() {Category = "Film & Media"},
                new EventCategory() {Category = "Kids" },
                new EventCategory() {Category = "Other"}
            };
        }
        private static IEnumerable<EventItem> GetPreconfiguredEventItems()
        {
            return new List<EventItem>
           {
               new EventItem()
               {
                   ///Here, add your items you created yesterday.



               }

           };
        }

        private static IEnumerable<EventVenue> GetPreconfiguredEventVenues()
        {
            return new List<EventVenue>()
            {
                //Here, add the list of venues I created to populate db.
                new EventVenue() {Venue= "Chateau Ste Michelle"},
                new EventVenue() {Venue= "Neumos"},
                new EventVenue() {Venue= "Lauren Ashton Cellars"},
                new EventVenue() {Venue= "Magnussen Park Hangar 30"},
                new EventVenue() {Venue= "Bottle House Seattle"},
                new EventVenue() {Venue= "McCaw Hall"}

            };
        }

        
    }
}
