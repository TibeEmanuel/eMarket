using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Contract;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
    public  class GetProductForEditQuery : Query
    {
        private int _productId { get; set; }
     
        public GetProductForEditQuery(int productId)
        {
              _productId = productId;
        }
      

        public override ViewModel Execute()
        {
            Product product = RepositoryFactory.ProductRepository.GetProductById(_productId); 

            ProductViewModel model = new ProductViewModel
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
