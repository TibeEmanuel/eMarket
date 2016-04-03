using eMarket.Datalayer;
using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMarket.DataLayer.Repositories
{


    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetProductCategory(ProductCategory productCategory);
    }




    public class ProductCategoryRepository : BaseRepository, IProductCategoryRepository
    {      

        public List<ProductCategory> GetProductCategory(ProductCategory productCategory)
        {
            return Get<ProductCategory>(productCategory).ToList();
            
        }

    }
}
