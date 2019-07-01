# EventBrite
EventBrite

Services:

1. Authentication/Login/permissions
2. Categories/Events (Similar to Catalog)
3. Create/Delete Event
4. Cart Service (Add to the cart)
5. Payment service
6. Search ( by name, category, price or price range, date or date range, by state, by city)
7. Help
8. Contact us
9. Create User account
10. Admin API authentication (user information, enable user, disable user, disable events, enable events, access database.)


//Example of what an event item would look like in Catalog:
List<EventItem>()
{

new EventItem() {EventTypeId=(1-3), 
                 EventVenueId=(1-3), 
                 Description="Indoor 80's Dance Mix from 9-5",
                 Name="Dance Party USA", 
                 Price=20.00,
                 PictureUrl="http://Awesome80sHits"},
}



/////Below is a description of an event item////
Event Item: 
EventVenue="Nectar" </br>
EventAddress="Fremont Seattle"
EventCategory="Music"
EventName="banjo fun"
EventDescription="Playing Banjos all night"  //Simple event description
EventFavorite=true/false         //This will be boolean, set to False
Price=20.00
PictureUrl="http://Awesome80sHits"     //This is the image for the hosting event
EventUrl="http://FremontNectar.com"     //This is the website for the hosting event

