using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.DataLayer.Repositories;
using eMarket.Datalayer.Entities; 

namespace eMarket.DataLayer.Contract
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAllProductCategories();

    }

}
