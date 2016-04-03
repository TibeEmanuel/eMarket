using eMarket.BusinessLayer.Queries; 
using eMarket.BusinessLayer.ViewModels;
using eMarket.Datalayer;
using eMarket.DataLayer.Contract;
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
        public ProductController(IQueryDispatcher queryDispatcher)
        {
            _queryDispatcher = queryDispatcher;
        }
        private IQueryDispatcher _queryDispatcher { get; set; }
        // GET: Product
        public ActionResult UploadProduct()
        {
            var model = _queryDispatcher.Execute<ProductViewModel>(new GetProductModelWithCategoriesQuery());

            return View(model);
        }
        [HttpPost]
        public ActionResult UploadProduct(ProductViewModel pvModel)
        {
            var model = _queryDispatcher.Execute<ProductViewModel>(new SaveAndGetCreatedProductIdQuery(pvModel));

            return RedirectToAction("EditProduct", new { productId = model.ProductId });
        }


        public ActionResult EditProduct(int productId)
        {
            var model = _queryDispatcher.Execute<ProductViewModel>(new GetProductForEditQuery(productId)); 
            return View(model);
        }
    }
}