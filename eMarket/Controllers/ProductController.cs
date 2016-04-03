using eMarket.BusinessLayer.Queries;
using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer;
using eMarket.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eMarket.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private IQueryRepository query { get; set; }
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: Product
        public ActionResult UploadProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadProduct(ProductViewModel model)
        {
            query = new SaveAndGetCreatedProductIdQuery(_repository,model);
            ProductViewModel responseModel = (ProductViewModel)query.Execute();

            return RedirectToAction("EditProduct", new  { productId = responseModel.ProductId });
        }


        public ActionResult EditProduct(int productId)
        {
            query = new GetProductForEditQuery(productId);
            var model = (ProductViewModel)query.Execute(); 
            return View(model);
        }
    }
}