using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ihff_project.Repository;
using ihff_project.Models;

namespace ihff_project.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository = new DbProductRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }
    }
}