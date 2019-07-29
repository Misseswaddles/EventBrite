# EventBrite
EventBrite

This EventBrite project is an ecommerce microservice written in C# in the ASP.Net core framework in Visual Studio 2019. The goal of this project was to gain understanding of how to compose an extensible ecommerce microservice from database, to microservices, and finally to a view. 

This project was seeded with actual events that occur from July through November 2019 and added to the Sql database using C#/Entity Framework to interface with Sql. These are events accurate from when the data was scraped from their respective websites and not updated. 

Basic Functionality:
User is able to access this website via localhost to view the list of events. User can use the dropdown menu to filter for preferred events. User must login to purchase an event which is provided by OAuth. Purchase of products is done through Stripe. Our program currently only allows one user and doesn't have capability for multi-users. The Stripe function is non-functioning--and represents a Dev account. 

Pending Updates:
As of 7/28/19, the next stage in the project is to add cart and order service to the site, to enable selecting an event, having cart and order service and finally ordering through stripe. We also want to add the Help and User microservice as well as a multiuser capability.

Goals for future development:
We are using Http protocol and it would be nice to use https to ensure Stripe usage is secured. Additionally, it would be awesome to create a webscraping microservice that autopopulates new events to keep the ecommerce site current. Additionally, it may be fun to research how to purhase such tickets for real, to fully recapitulate a fully functional EventBrite microservice.

