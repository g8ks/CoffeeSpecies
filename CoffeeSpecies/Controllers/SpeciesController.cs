using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeSpecies.Controllers
{
    [Route("api/v1/Coffee/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        static IList<Species> Species = new List<Species>();
        public SpeciesController()
        {
            Species.Add(new Species() { id=Guid.NewGuid(),name= "Arabica",
                imageUrl= "https://alicecoffeeshop.devtesting.live/images/arabica.png",
                price= 120.99,
                description= "This coffee bean with low caffeine and a smoother taste is aromatic and delicious. 80% of the coffee in the world is produced from these types of beans."
            });
            Species.Add(new Species()
            {
                id= Guid.NewGuid(),
                name="Liberica",
                imageUrl= "https://alicecoffeeshop.devtesting.live/images/liberica.png",
                price= 89.99,
                description= "Liberica is a low yield type of coffee compared to Arabica and Robusta."
            });
            Species.Add(new Species()
                {
                    id = Guid.NewGuid(),
                    name= "Robusta",
                    imageUrl= "https://alicecoffeeshop.devtesting.live/images/robusta.png",
                    price= 110.99,
                    description="This type of coffee, which contains 2.5% more caffeine than other types, has a pretty strong taste."
                }
           );
        }
        [HttpGet]
        [Route("")]
        public Task<IList<Species>> Get()
        {
            return Task.FromResult(Species);

        }
    }
}
