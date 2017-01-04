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
        public List<int> pp = new List<int>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {
            IEnumerable<AllFilmInfo> filmList = productRepository.GetAllFilmsDag(3);
            ViewBag.pp = pp;
            
            return View(filmList);
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Buy")]
        public ActionResult Buy(AllFilmInfo film)
        {
            pp.Add(1);
            pp.Add(3);
            return RedirectToAction("Events");
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Programme")]
        public ActionResult Programme(AllFilmInfo film)
        {
            return RedirectToAction("Events");
        }

        public ActionResult Restaurants()
        {
            IEnumerable<Restaurants> restaurants = productRepository.GetAllRestaurants();
            return View(restaurants);
        }
    }
}