using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {
        //creating subclasses to talk to each microservices
        public static class Events //events catalog
        {
            public static string GetAllCategories(string baseUri)   //plan to give you a url to get the API, baseUri is as parameter passedf rom docker
            {
                return $"{baseUri}EventCategories"; //baseUri here would be http:/\/\localhost:61290/api/events/
            }

            public static string GetAllVenues(string baseUri)
            {
                return $"{baseUri}EventVenue";
            }

            public static string GetAllEventItems(string baseUri, int page, int size, int? brand, int? type ) //you have to pass page and size. But brand andtype are nullable value types.
            {
                return $"{baseUri}items?pageSize={size}&pageIndex={page}";  //Need to implement brand and type
            }

        }
    }
}
