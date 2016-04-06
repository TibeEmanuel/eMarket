using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.DataLayer.Repositories;
using eMarket.Datalayer.Entities; 

namespace eMarket.DataLayer.Contract
{
    public interface IProductRepository
    {
        int SaveProductReturnId(Product product);

        Product GetProductById(int _productId);
    }
}
