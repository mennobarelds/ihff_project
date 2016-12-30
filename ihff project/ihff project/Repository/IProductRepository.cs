using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ihff_project.Models;

namespace ihff_project.Repository
{
    interface IProductRepository
    {
        IEnumerable<AllFilmInfo> GetAllFilmsDag(int dag);
        IEnumerable<Voorstellingen> GetAllVoorstellingenFilm(int filmId);
        Producten GetVoorstellingen(int productId);
        Films GetFilm(int filmId);
        Voorstellingen GetVoorstelling(int productId);
        void EditFilm(Films film);
        IEnumerable<Restaurants> GetAllRestaurants();

    }
}
