using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Data;
using EventCatalogAPI.Domains;
using EventCatalogAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventContext _context;
        private readonly IConfiguration _config;

        public EventsController(EventContext context,
            IConfiguration config)
        {
            _context = context;

            _config = config; //note, "ExternalCatalogBaseUrl" in config file is for Carols machine. Change the config to match your settings but DO not push that change.
        }

        //GET api/events/items?pageSize=4&pageIndex=2
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery]int pageSize = 10,
            [FromQuery]int pageIndex = 0)
        {
            var itemsCount = await _context.EventItems.LongCountAsync();

            var items = await _context.EventItems
                .OrderBy(c => c.EventName)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToListAsync();
            items = ChangePictureUrl(items);
            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageSize = pageSize,
                PageIndex = pageIndex,
                Count = itemsCount,
                Data = items
            };

            return Ok(model);
        }

      private List<EventItem> ChangePictureUrl(
          List<EventItem> items)
        {
            items.ForEach(
                e =>
                e.EventPictureUrl =
                 e.EventPictureUrl.Replace("http://externaleventcatalogbaseurltobereplaced",
                 _config["ExternalCatalogBaseUrl"]));

            return items;

        }

        //returns the list of event categories in alphabetical order
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventCategories()
        {
            var itemscount = await _context.EventCategories.LongCountAsync();

            var items = await _context.EventCategories
            .OrderBy(c => c.Category)
            .ToListAsync();

            return Ok(items);
        }

        //returns a list of the event venues in alphabetical order
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventVenue()
        {
            var itemscount = await _context.EventVenues.LongCountAsync();

            var items = await _context.EventVenues
                .OrderBy(c => c.Venue)
                .ToListAsync();

            return Ok(items);
        }

        //returns a list of startdates
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventStartDate()
        {
            var items = await _context.EventStartDates.ToListAsync();
            return Ok(items);
        }

        //returns item details by id
        [HttpGet]
        [Route("items/{id:int}")]
        public async Task<IActionResult> GetItemsById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Incorrect Id given!");
            }

            var item = await _context.EventItems.SingleOrDefaultAsync(c => c.Id == id);

            if(item==null)
            {
                return NotFound("Your event wasn't found");

            }

            item.EventPictureUrl = item.EventPictureUrl 
                                       .Replace("http://externaleventcatalogbaseurltobereplaced", _config["ExternalCatalogBaseUrl"]);

            return Ok(item);
                        
        }





    }
}