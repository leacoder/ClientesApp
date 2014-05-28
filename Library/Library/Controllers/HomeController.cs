using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using System.Collections.Generic;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "General Information";
            ProductosViewModel ProductoViewModel = new ProductosViewModel();
            ProductoViewModel.addProduct(new Producto(2, "nada", "jose", 4));



            return View(ProductoViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
