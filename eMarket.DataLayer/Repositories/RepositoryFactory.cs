using eMarket.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Repositories
{

    public interface IRepositoryFactory
    {
        IImageRepository ImageRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }
    }



    public class RepositoryFactory :IRepositoryFactory
    {
        
        
        public IImageRepository ImageRepository
        { 
            get 
            {
                return new ImageRepository();
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return new ProductRepository();
            }
        }

        public IProductCategoryRepository ProductCategoryRepository
        {
            get
            {
                return new ProductCategoryRepository();
            }
        }

    }
}
