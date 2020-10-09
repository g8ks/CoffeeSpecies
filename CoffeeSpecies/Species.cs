using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeSpecies
{
    public class Species
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }

        public double price { get; set; }

        public string description { get; set; }
    }
}
