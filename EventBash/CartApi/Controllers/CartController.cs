using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CartApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartApi.Controllers
{
    [Route("api/v1/[controller]")]

    public class CartController : Controller
    {
        private ICartRepository _repository;
       // private readonly ILogger _logger;
        //public CartController(ICartRepository repository,ILoggerFactory logger)
         public CartController(ICartRepository repository)   
        {
            _repository = repository;
           // _logger = logger.CreateLogger<CartController>();
        }

        // GET api/v1/cart/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Cart), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(string id)
        {
            var basket = await _repository.GetCartAsync(id);
            return Ok(basket); //return basket ; This would also work
        }

        // POST api/v1/cart
        [HttpPost]

        [ProducesResponseType(typeof(Cart), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post([FromBody]Cart value)
        {
            System.Diagnostics.Debug.WriteLine("\n\n The value passed to CartAPI Cartcontroller is:");
            System.Diagnostics.Debug.WriteLine(value.BuyerId);
            System.Diagnostics.Debug.WriteLine(value.Items);
            System.Diagnostics.Debug.WriteLine("\n\n");
            var basket = await _repository.UpdateCartAsync(value);
            return Ok(basket);
        }

        // DELETE api/v1/cart/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
          //  _logger.LogInformation("Delete method in Cart controller reached");
            _repository.DeleteCartAsync(id);
        }
    }
}