using eMarket.Datalayer;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMarket.DataLayer.Repositories
{

    public class ProductCategoryRepository : BaseRepository, IProductCategoryRepository
    {      

        public List<ProductCategory> GetAllProductCategories()
        {
            return base.Get<ProductCategory>().ToList();
            
        }


    }
}
