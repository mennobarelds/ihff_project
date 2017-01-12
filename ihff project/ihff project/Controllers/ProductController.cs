﻿using System;
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

        public ActionResult Events(int dag)
        {
            IEnumerable<AllFilmInfo> filmList;

            if (dag >= 3 && dag <= 7)
                filmList = productRepository.GetAllFilmsDag(dag);
            else
                filmList = productRepository.GetAllFilms();

            switch(dag)
            {
                case 3:
                    ViewBag.Dag = "Wednesday";
                    break;
                case 4:
                    ViewBag.Dag = "Thursday";
                    break;
                case 5:
                    ViewBag.Dag = "Friday";
                    break;
                case 6:
                    ViewBag.Dag = "Saterday";
                    break;
                case 7:
                    ViewBag.Dag = "Sunday";
                    break;
                default:
                    ViewBag.Dag = "the programme";
                    break;
            }
                
            return View(filmList);
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "Buy")]
        public ActionResult Buy(AllFilmInfo film)
        {
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

        public ActionResult Cultuur()
        {
            IEnumerable<Locaties> l = productRepository.GetAllLocaties();
            return View(l);
        }

        public ActionResult FilmDetail(int product_ID)
        {
            IEnumerable<AllFilmInfo> film = productRepository.GetVoorstellingen(product_ID);
            return View(film.First<AllFilmInfo>());
        }

        public ActionResult RestaurantDetail()
        {
            return View();
        }
    }
}