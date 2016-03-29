using eMarket.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Datalayer.Entities
{
    public class Product : Entity
    {       
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public ProductCategory ProductCategory;
        public string SellerId { get; set; }
        [ForeignKey("SellerId")]
        public EmarketUser Seller { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}
