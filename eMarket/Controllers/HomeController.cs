using eMarket.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 


namespace eMarket.Controllers
{
    public class HomeController : Controller
    {
        //TODO... 
        //private IOrderByName _productOrder;

        //public HomeController(IOrderByName productOrder)
        //{
        //    _productOrder = productOrder;
        //}

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page is changed after the finishal.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}