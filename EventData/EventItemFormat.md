
**This document contains the general structure of an event Item**
</br>
</br>
General guidlines: </br>
Take information from a real event--then the images and url are already there for you. 
</br>
</br>
Below is an example for the TedX seattle event in November </br>
TedEx Seattle Nov </br>
<pre>
new EventItem() { EventCategory=3, 
                    EventVenue=6, 
                    EventDescription="Talks on a moment of change from one position to another,
                    whether it be in relationships, beliefs, cultures, perspectives or the world",</br> 
                    EventName="TEDxSeattle 2019: SHIFT",</br>
                    EventCost=20.00,</br>
                    EventAddress="321 Mercer St",</br>
                    EventCity="Seattle",</br> 
                    EventState="Washington",</br>
                    EventZip=98109,</br> 
                    EventFavorite=false,</br> 
                    EventTicketsAvailable=100 , 
                    EventStartDateTime="11/23/19", </br>
                    EventEndDateTime="11/23/19",</br>
                    EventPictureUrl="http://replace/TedEx_SHIFT_2019.PNG",</br>
                    EventUrl="https://tedxseattle.com/"
                    }

</pre> 

**Below is a blank item that you can use to create an EventItem**
new EventItem() { EventCategory=  , EventVenue=  , EventDescription=  , EventName=   , EventCost=   , EventAddress= , EventCity=  , EventState=  , EventZip=  , EventFavorite= , EventTicketsAvailable= , EventStartDateTime=  ,  EventEndDataTime= , EventPictureUrl=  , EventUrl= }


**Assign a category by using one the corresponding numbers for the venues:**
//(Music, Food & Drink ,  Seminars, Kids, Drama, Outdoor, Dance) 
new EventCategory() {Category = "Music"},  1   </br>
new EventCategory() {Category = "Food & Drink"}, 2  </br>
new EventCategory() {Category = "Seminars" },  3    </br>
new EventCategory() {Category = "Film & Media"}, 4  </br>
new EventCategory() {Category = "Kids" },  5 
new EventCategory() {Category = "Other"} 6

So, if you have a music category you would add use EventCategory=1

**Below is the EventVenue Domain**

new EventVenue() {Venue= "Chateau Ste Michelle"},  1
new EventVenue() {Venue= "Neumos"},      2
new EventVenue() {Venue= "Lauren Ashton Cellars"}, 3
new EventVenue() {Venue= "Magnussen Park Hangar 30"}, 4
new EventVenue() {Venue= "Bottle House Seattle"}, 5
new EventVenue() {Venue= "McCaw Hall"} 6

Same logic as category



