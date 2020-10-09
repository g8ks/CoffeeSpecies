using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeSpecies
{
    public class OrderRequest
    {
        public string name { get; set; }
        public string address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public string phoneNo { get; set; }

        public IList<OrderItem> items { get; set; }
    }
}
