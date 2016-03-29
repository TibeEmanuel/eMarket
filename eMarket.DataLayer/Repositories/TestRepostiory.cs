using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Datalayer.Entities;

namespace eMarket.DataLayer.Repositories
{
   public class TestRepostiory : IRepository
    {

        //public void Add<TModel>(TModel Entity) where TModel : Datalayer.Entity
        //{
        //    throw new NotImplementedException();
        //}

        public IQueryable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductCategory> GetProductCategoryById(int productCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
