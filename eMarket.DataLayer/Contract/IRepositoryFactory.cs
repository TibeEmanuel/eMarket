using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer.Contract
{
    public interface IRepositoryFactory
    {
        IImageRepository ImageRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }
        IAnnouncementRepository AnnouncementRepsitory { get; }

    }
}
