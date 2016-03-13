using eMarket.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emarket.BusinessLayer
{
    public class Class1
    {
        

        public void GetProductById(int prtId)
        {
            using (var context = new EmarketContext())
            {
               return context.Products.FirstOrDefault(p => p.Id); 
            } 
        }
    }
}
