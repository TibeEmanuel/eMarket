using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.BusinessLayer.Queries
{
    public class SaveAndGetCreatedProductIdQuery : IQuery
    {
        private ProductViewModel _productMdl { get; set; }
        private IProductRepository _repository ;

        public SaveAndGetCreatedProductIdQuery( ProductViewModel model)
        {
            _repository = new ProductRepository();
            _productMdl = model;
        }


        public ViewModel Execute()
        {
            var product = new Product()
            {
                Name = _productMdl.Name,
                Price = _productMdl.Price,
                ProductCategoryId = _productMdl.ProductCategoryId,
                SellerId = _productMdl.SellerId,
                Description = _productMdl.Description
            };
            //var result = ProductViewModel.Product(_productMdl);  // implicit
            // conversion from ProductViewModel to Product Model

            _productMdl.ProductId = _repository.SaveProductReturnId(product);

            return _productMdl;

        }
    }
}
