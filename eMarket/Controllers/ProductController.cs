using eMarket.BusinessLayer.Queries;
using eMarket.BusinessLayer.ViewModels;
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
        private IQuery query { get; set; }
        // GET: Product
        public ActionResult UploadProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadProduct(ProductViewModel model)
        {
            query = new GetCreateProductIdQuery(model);
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