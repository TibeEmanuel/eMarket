using eMarket.Datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace eMarket.Datalayer
{
    public class ProductCategory 
    {
        [Key]
        public int ProductCatagoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
