using eMarket.Datalayer;
using eMarket.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace eMarket.Datalayer.Entities
{
    public class ProductCategory : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation properties are typically defined as virtual so that they can 
        //take advantage of certain Entity Framework functionality such as lazy loading.

        //The list of products in a particular category
        public virtual ICollection<Product> Products { get; set; }
    }
}
