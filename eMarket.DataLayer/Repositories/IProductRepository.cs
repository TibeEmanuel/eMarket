using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Repositories
{
    public interface IProductRepository
    {
        int SaveProductReturnId(Product product);

        Product GetProductById(int _productId);
    }
}
