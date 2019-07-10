using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext context)
        {
            context.Database.Migrate(); 

            //Only fill up the database if you don't have anything in there.
            if (!context.EventVenues.Any())
            {
                context.EventVenues.AddRange(GetPreconfiguredEventVenues());

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


            if (!context.EventItems.Any())
            {
                context.EventItems.AddRange(GetPreconfiguredEventItems());

                context.SaveChanges();
            }


        }

        private static IEnumerable<EventItem> GetPreconfiguredEventItems()
        {
            return new List<EventItem>
           {
              
               
                  
                  new EventItem() { EventCategoryId=3, EventVenueId=6, EventStartDateId=1, EventDescription="Talks on a moment of change from one position to another, whether it be in relationships, beliefs, cultures, perspectives or the world"  , EventName="TEDxSeattle 2019: SHIFT"   , EventCost=20.00m   , EventAddress="321 Mercer St" , EventCity="Seattle"  , EventState="Washington"  , EventZip=98109  , EventFavorite=false , EventTicketsAvailable=100 , EventStartTime="8:00"  ,  EventEndDate="11/23/19", EventEndTime="17:00", EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/1"  , EventUrl="https://tedxseattle.com/" },
                  new EventItem() { EventCategoryId=2, EventVenueId=5, EventStartDateId=2 , EventDescription="Food and wine celebration of Bastille Day"  , EventName="Bastille Day Patio Party"   , EventCost=19.00m   , EventAddress="1416 34Th Ave" , EventCity="Seattle"  , EventState="Washington"  , EventZip=98122  , EventFavorite=false , EventTicketsAvailable=100 , EventStartTime="15:00"  ,  EventEndDate="7/14/19" ,  EventEndTime="18:00"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/2"   , EventUrl="http://www.bottlehouseseattle.com/happenings/" },
                  new EventItem() { EventCategoryId=2, EventVenueId=4, EventStartDateId=1 , EventDescription="Specialty food show connecting local food craftsman with everyday customers."  , EventName="Gobble Up Seattle"   , EventCost=0.00m   , EventAddress="6310 NE 74th St " , EventCity="Seattle"  , EventState="Washington"  , EventZip=98115 , EventFavorite=false, EventTicketsAvailable=200 , EventStartTime="10:00"  ,  EventEndDate="11/23/19",  EventEndTime="17:00"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/3" , EventUrl="https://gobbleupnorthwest.com/" },
                  new EventItem() { EventCategoryId=2, EventVenueId=3, EventStartDateId=3 , EventDescription="Formal instruction on pairing cheese with Lauren Ashton wine selections."  , EventName="The Art of Cheese"   , EventCost=85.00m   , EventAddress="14545 148th Ave NE, Suite 211" , EventCity="Woodinville"  , EventState="Washington" , EventZip=98072 , EventFavorite=false , EventTicketsAvailable=30 , EventStartTime="18:00" ,  EventEndDate="8/22/19" ,  EventEndTime="20:00"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/4"  , EventUrl="http://laurenashtoncellars.com/calevent/the-art-of-cheese/" },
                  new EventItem() { EventCategoryId=1, EventVenueId=2, EventStartDateId=4 , EventDescription="70’s & 80’s Music All Night Long!"  , EventName="Bohemian Rhapsody - Queen Inspired Dance Party"   , EventCost=5.00m   , EventAddress="925 East Pike Street" , EventCity="Seattle"  , EventState="Washington" , EventZip=98122  , EventFavorite=false , EventTicketsAvailable=100 , EventStartTime="11:00"  ,  EventEndDate="7/28/10" ,  EventEndTime="1:00"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/5"  , EventUrl="http://www.neumos.com/event/1864161-bohemian-rhapsody-queen-seattle/" },
                  new EventItem() { EventCategoryId=2, EventVenueId=1, EventStartDateId=6 , EventDescription="Live summer concert with Pink Martini and singer China Forbes"  , EventName="An Evening with Pink Martini with singer China Forbes"   , EventCost=79.00m   , EventAddress="14111 NE 145th Street" , EventCity="Woodinville"  , EventState="Washington"  , EventZip=98072  , EventFavorite=false , EventTicketsAvailable=100 , EventStartTime="19:00"  ,  EventEndDate="9/6/19" ,  EventEndTime="21:00"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/6"  , EventUrl="https://www.ste-michelle.com/visit-us/events-calendar/an-evening-with-pink-martini-with-singer-china-forbes?concert=1" },
                  new EventItem() { EventCategoryId=1, EventVenueId=2, EventStartDateId=5 , EventDescription="The Yacht Rock Revue is everything the late ‘70s and early ‘80s should’ve been!"  , EventName="Yacht Rock Revue"   , EventCost=25.00m   , EventAddress="925 East Pike Street" , EventCity="Seattle"  , EventState="Washington"  , EventZip=98122  , EventFavorite=false , EventTicketsAvailable=125 , EventStartTime="20:00"  ,  EventEndDate="8/4/19" ,  EventEndTime="23:55"  , EventPictureUrl="http://externaleventcatalogbaseurltobereplaced/api/pic/7"  , EventUrl="http://www.neumos.com/event/1861114-yacht-rock-revue-seattle/" }
           
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


    }
}
