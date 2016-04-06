using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Contract
{
    public class RepositoryFactory: IRepositoryFactory
    {
        public IImageRepository ImageRepository
        {
            get { return new ImageRepository(); }
        }

        public IProductRepository ProductRepository
        {
            get { return new ProductRepository(); }

        }
        public IProductCategoryRepository ProductCategoryRepository
        {
            get { return new ProductCategoryRepository(); }

        }
        public IAnnouncementRepository AnnouncementRepsitory
        {
            get { return new AnnouncementRepository(); }

        }

    }
}
