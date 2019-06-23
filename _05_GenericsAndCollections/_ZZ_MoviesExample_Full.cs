using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections
{
    class _ZZ_MoviesExample_Full
    {
        void AddMovies()
        {
            Movies<string,DateTime> movie1 = new Movies<string,DateTime>();
            movie1.MovieName = "movie1";
            movie1.Director = "dir1";
            movie1.releaseDate = DateTime.Now;
            movie1.rate = "B";
        }
    }

    class Movies<T,U>
    {
        public string MovieName { get; set; }
        public string Director { get; set; }
        public U releaseDate { get; set; }
        public T rate { get; set; }
    }
}
