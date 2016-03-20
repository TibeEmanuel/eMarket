using eMarket.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace emarket.BusinessLayer
{
    public class Class1
    {
        

        public void GetProductById(int productId)
        {
            var context = new EmarketContext();
            context.Products.FirstOrDefault(p => p.id== productId);

        }
    }
}
