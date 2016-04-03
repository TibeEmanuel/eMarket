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
    public class GetProductModelWithCategoriesQuery : Query
    {
        private ProductViewModel _productMdl { get; set; }
        public GetProductModelWithCategoriesQuery ()
	  {

	 }

        public override ViewModel Execute()
        {
            var ProductCategories = RepositoryFactory.ProductCategoryRepository.GetAllProductCategories();
            var prtModel = new ProductViewModel();
           var models = new List<ProductCategoryViewModel>();
           foreach (var prt in ProductCategories)
           {
               models.Add(new ProductCategoryViewModel { CategoryId = prt.Id, Description = prt.Description, Name = prt.Name }); 
           }
           prtModel.ProductCategories = models; 
             return prtModel;
        }
    }
}
