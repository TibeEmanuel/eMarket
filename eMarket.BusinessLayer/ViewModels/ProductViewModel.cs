using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.ViewModels
{
    public class ProductViewModel : ViewModel 
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int ProductCategoryId { get; set; }
        
        public string SellerId { get; set; }
        public List<int> ImageIds { get; set; }

    }
}
