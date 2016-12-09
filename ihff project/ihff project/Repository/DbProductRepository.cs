using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff_project.Models;

namespace ihff_project.Repository
{
    public class DbProductRepository : IProductRepository
    {
        private iHFF1617S_B3Entities ctx = new iHFF1617S_B3Entities();

        public IEnumerable<Film> GetAllFilms()
        {
            IEnumerable<Film> allFilms = ctx.Films;
            return allFilms;
        }

        public IEnumerable<Voorstellingen> GetAllVoorstellingenFilm(int filmId)
        {
            IEnumerable<Voorstellingen> allVoorstellingen = ctx.Voorstellingens.Where(c => c.Film_ID == filmId);
            return allVoorstellingen;
        }

        public Producten GetVoorstellingen(int productId)
        {
            return ctx.Productens.SingleOrDefault(c => c.Product_ID == productId);
        }

        public Film GetFilm(int filmId)
        {
            return ctx.Films.SingleOrDefault(c => c.Film_ID == filmId);
        }

        public Voorstellingen GetVoorstelling(int productId)
        {
            return ctx.Voorstellingens.SingleOrDefault(c => c.Product_ID == productId);
        }

        public void EditFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}