﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff_project.Models;

namespace ihff_project.Repository
{
    public class DbProductRepository : IProductRepository
    {
        private iHFF1617S_B3E ctx = new iHFF1617S_B3E();

        public IEnumerable<AllFilmInfo> GetAllFilmsDag(int dag)
        {
            var query = (from producten in ctx.Producten
                        join voorstellingen in ctx.Voorstellingen on producten.Product_ID equals voorstellingen.Product_ID
                        join films in ctx.Films on voorstellingen.Film_ID equals films.Film_ID
                        
                        select new AllFilmInfo()
                        {
                            Product_ID = producten.Product_ID,
                            Naam = producten.Naam,
                            Beschrijving_NL = films.Beschrijving_NL,
                            Beschrijving_EN = films.Beschrijving_EN,
                            Genre = films.Genre,
                            Acteurs = films.Acteurs,
                            IMDb_rating = films.IMDb_rating,
                            Dag = voorstellingen.Dag,
                            Tijd = voorstellingen.Tijd,
                            Zaal = voorstellingen.Zaal,
                            Image_path = films.Image_path,
                            Prijs = producten.Prijs
                        }).ToList();

            return query;
        }

        public IEnumerable<Voorstellingen> GetAllVoorstellingenFilm(int filmId)
        {
            IEnumerable<Voorstellingen> allVoorstellingen = ctx.Voorstellingen.Where(c => c.Film_ID == filmId);
            return allVoorstellingen;
        }

        public Producten GetVoorstellingen(int productId)
        {
            return ctx.Producten.SingleOrDefault(c => c.Product_ID == productId);
        }

        public Films GetFilm(int filmId)
        {
            return ctx.Films.SingleOrDefault(c => c.Film_ID == filmId);
        }

        public Voorstellingen GetVoorstelling(int productId)
        {
            return ctx.Voorstellingen.SingleOrDefault(c => c.Product_ID == productId);
        }

        public void EditFilm(Films film)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurants> GetAllRestaurants()
        {
            IEnumerable<Restaurants> allRestaurants = ctx.Restaurants;
            return allRestaurants;
        }
    }
}