using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Datalayer
{
    public class Product: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        [ForeignKey("ProductCatagory")]
        public int ProductCatagoryId { get; set; }
        public virtual ProductCategory ProductCatagory { get; set; } // This is the navigation property


    }
}
