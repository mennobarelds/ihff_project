using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff_project.Models;

namespace ihff_project.Repository
{
    public class DbProductRepository : IProductRepository
    {
        private iHFF1617S_B3 ctx = new iHFF1617S_B3();

        public IEnumerable<Films> GetAllFilms()
        {
            IEnumerable<Films> allFilms = ctx.Films;
            return allFilms;
        }

        public IEnumerable<Voorstellingen> GetAllVoorstellingenFilm(int filmId)
        {
            IEnumerable<Voorstellingen> allVoorstellingen = ctx.Voorstellingen.Where(c => c.Film_ID == filmId);
            return allVoorstellingen;
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

        public IEnumerable<Producten> GetAllProducten()
        {
            IEnumerable<Producten> allProducts = ctx.Producten;
            return allProducts;
        }

        public IEnumerable<AllFilmInfo> GetAll()
    }
}