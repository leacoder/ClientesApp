using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Library.Models;
using Database;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductoDB productoDB = new ProductoDB();
            List<Producto> listaProductosVenta = productoDB.FiveProducts();
            ViewBag.Message = "General Information";
            ProductosViewModel ProductoViewModel = new ProductosViewModel(listaProductosVenta,"Articulos");
            



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
