using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer
{
    public class Product: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int ProductCatagoryId { get; set; }
        public ProductCatagory ProductCatagory { get; set; }

    }
}
