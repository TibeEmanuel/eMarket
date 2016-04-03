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
    public class SaveAndGetCreatedProductIdQuery : IQueryRepository
    {
        private ProductViewModel _productMdl { get; set; }
        private IProductRepository _repository;

        public SaveAndGetCreatedProductIdQuery(IProductRepository repo, ProductViewModel model)
        {
            _repository = repo;
            //_repository = new ProductRepository();
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
            
            _productMdl.ProductId = _repository.SaveProductReturnId(product);

            return _productMdl;

        }
    }
}
