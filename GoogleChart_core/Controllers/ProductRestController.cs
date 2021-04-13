using GoogleChart_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleChart_core.Controllers
{
    [Route("api/product")]
    public class ProductRestController : Controller
    {

        [HttpGet("findall")]
        [Produces("application/json")]
        public async Task<IActionResult> findAll()
        {
            try
            {
                var products = new List<Product>
                {
                    new Product { Id = "p01", Name = "Product 1", Price = 100, Quantity = 20 },
                    new Product { Id = "p02", Name = "Product 2", Price = 120, Quantity = 12 },
                    new Product { Id = "p03", Name = "Product 3", Price = 80, Quantity = 60 },
                    new Product { Id = "p04", Name = "Product 4", Price = 290, Quantity = 34 },
                    new Product { Id = "p05", Name = "Product 5", Price = 200, Quantity = 29 }
                };
                return Ok(products);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
