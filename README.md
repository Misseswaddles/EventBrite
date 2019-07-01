# EventBrite
EventBrite


Process:
We will work on one specific Visual Studio project.
Each person will work within their own API project.
As a general practice, do not modify code in another person's API, unless you are working with the author of that API.
Document Any changes and update your readme for your project.

Features of the Application:




Services:

1. Authentication/Login/permissions
2. Categories/Events (Similar to Catalog) 
3. Create/Delete Event
4. Cart Service (Add to the cart)
5. Payment service  (separate API, stripe)
6. Search ( by name, category, price or price range, date or date range, by state, by city) (Sri)
7. Help
8. Contact us
9. Create User account
10. Admin API authentication (user information, enable user, disable user, disable events, enable events, access database.)

//LInk to Mapquest API to show the location.


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



/////Below is a description of an event item//// </br>
EventId: (Autogenerated Primary Key PK)</br>
EventVenue="Nectar" </br>
EventStreetAddress="Fremont Seattle" </br>
EventCity="Seattle"</br>
EventState="Washington"</br>
EventZip=90201 </br>
EventCategory="Music" (Music, Kids, Drama, Outdoor, Dance, Food, Wine)   (Foreign key) </br>
EventName="banjo fun" </br>
EventDescription="Playing Banjos all night"  //Simple event description </br>
EventFavorite=true/false         //This will be boolean, set to False </br>
EventTicketsAvailable=100 </br>
EventTimeStart=10am (date/time object)
EventTimeEnd=6pm (date/time object)
EventDateStart=7/6/19 (date/time object)
EventEndDate-7/6/19 (date/time object)
EventPrice=20.00  </br>
EventPictureUrl="http://Awesome80sHits"     //This is the image for the hosting event </br>
EventUrl="http://FremontNectar.com"     //This is the website for the hosting event </br>

////////CategoryDescription/////</br>
CategoryId: (auto Primary Key) </br>
CategoryName: "Music" (choices Music, Kids, Drama, Outdoor, Dance, Food, Wine) </br>
CategoryDescription: "Live music" </br>

///User Favorites//   this table will store the user's favorite events</br>
UserId: (from user information)
EventId: 
IsBooked: true/false
IsFavorite: 


///User Events////
UserId:
EventId:
IsFavorite: true/false
IsBooked: true/false


///book Event///
EventId:
BookingId:  (auto pk)
UserId:  


/////////User information ///</br>
FirstName: </br>
LastName: </br>
UserName: "User name to access account front end facing" </br>
UserId: </br>  (autogenerated user ID)
Password: </br>
BillingAddresss: </br>
Email: </br>
Phone: </br>
CardNumber: </br>
CardExpire: </br>
CardCV: </br>
CompanyOrIndividual: "string" </br>
CanCreateEvent: false/true (default is enabled, but can be disabled, diaabled until they are enabled) </br>
Permissions:  1,2,3 ( Admin, Host or General)
Favorites: 



//////Permissions///</br>
PermissionId: 1, 2, 3 </br>
PermissionName: Admin, HOst, General </br>
PermissionDescription:   "Admin access", "Can only create/delete own events, and sign up for others", "sign up for other events, notify about events" </br>
AppFeatures: foreign key


////AppFeatures/////
FeatureId:
FeatureName:
FeatureDescription:
CreateEvent: true/false
EnableEvent: true/false
EnableUser: true/false











