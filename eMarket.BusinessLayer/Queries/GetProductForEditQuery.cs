using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
    public class GetProductForEditQuery : IQuery
    {
        private int _productId { get; set; }
        private IProductRepository repository = new ProductRepository();

        public GetProductForEditQuery(int productId)
        {
            _productId = productId;
        }
        

        public ViewModel Execute()
        {
            Product product = repository.GetProductById(_productId);
            var model = new ProductViewModel
                     {
                         Name = product.Name,
                         Price = product.Price,
                         ProductCategoryId = product.ProductCategoryId,
                         SellerId = product.SellerId,
                         Description = product.Description
                     };


            return model;

        }
    }
}
