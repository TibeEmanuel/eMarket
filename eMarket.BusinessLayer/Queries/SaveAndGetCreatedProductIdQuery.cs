using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Contract;
using eMarket.DataLayer.Entities;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Web;



namespace eMarket.BusinessLayer.Queries
{
    public class SaveAndGetCreatedProductIdQuery : Query
    {
        private ProductViewModel _productMdl { get; set; }
        //private string _userId;
        public SaveAndGetCreatedProductIdQuery( ProductViewModel model)
        {
           
            _productMdl = model;
        }


        public override ViewModel Execute()
        {
           
            var product = new Product()
            {
                Name = _productMdl.Name,
                Price = _productMdl.Price,
                ProductCategoryId = _productMdl.ProductCategoryId,
                SellerId =_productMdl.SellerId, 
                Description = _productMdl.Description
              
            };

            _productMdl.ProductId = RepositoryFactory.ProductRepository.SaveProductReturnId(product); 

            return _productMdl;

        }
    }
}
