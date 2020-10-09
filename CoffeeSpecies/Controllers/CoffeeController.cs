using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeSpecies.Controllers
{
    [Route("api/v1/Order/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        static IList<OrderRequest> OrderRequests = new List<OrderRequest>();
        public CoffeeController()
        {
            
        }
        [HttpPost]
        public ActionResult Create(OrderRequest dto)
        {
            OrderRequests.Add(dto);
            return Ok();
        }
    }
}
