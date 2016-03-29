using eMarket.Datalayer;
using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace eMarket.DataLayer.Repositories
{
    public class Repository : IRepository
    {
        EmarketContext _ctx;

        // passing context in the constructor helps us to use any of context that exists in the application.
        public Repository(EmarketContext ctx)
        {
            _ctx = ctx;
        }
        public Repository()
        {

        }

        public IQueryable<Product> GetProducts()
        {
            return _ctx.Products;

        }

        public IQueryable<ProductCategory> GetProductCategoryById(int productCategoryId)
        {
            return _ctx.ProductCategories.Where(r => r.Id == productCategoryId);

        }

    }
}
