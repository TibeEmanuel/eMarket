using eMarket.Datalayer;
using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


    public class ProductRepository :BaseRepository, IProductRepository
    {
    
        public int SaveProductReturnId(Product product)
        {
            
            AddOrUpdateEntity<Product>(product);

            return product.Id;
        }


        public Product GetProductById(int _productId)
        {
            
            return GetById<Product>(_productId);
           
        }
    }
}
