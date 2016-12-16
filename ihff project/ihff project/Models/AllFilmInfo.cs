using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ihff_project.Models
{
    public class AllFilmInfo
    {
        public int Film_ID { get; set; }
        public string Genre { get; set; }
        public string Beschrijving { get; set; }
        public Nullable<double> IMDb_rating { get; set; }
        public string Image_path { get; set; }
        public int Product_ID { get; set; }
        public string Dag { get; set; }
        public string Tijd { get; set; }
        public Nullable<int> Plaatsen_Over { get; set; }
        public string Zaal { get; set; }
        public string Naam { get; set; }
        public Nullable<double> Prijs { get; set; }
    }
}