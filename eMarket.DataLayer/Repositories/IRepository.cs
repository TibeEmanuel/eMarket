using eMarket.Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace eMarket.DataLayer.Repositories
{
    public interface IRepository
    {

       
        // IQueryable<> is used to allow users of the repository to paging, ordering or filtering ..etc.
        IQueryable<Product> GetProducts();
        IQueryable<ProductCategory> GetProductCategoryById(int productCategoryId);

        
    }
}
