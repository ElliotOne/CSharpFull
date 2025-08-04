using System;

namespace _05_GenericsAndCollections
{
    class _08_MoviesExample
    {
        void AddMovies()
        {
            Movies<string, DateTime> movie1 = new Movies<string, DateTime>();

            movie1.Name = "movie1";
            movie1.Director = "dir1";
            movie1.ReleaseDate = DateTime.Now;
            movie1.Rate = "B";

            Movies<int, DateTime> movie2 = new Movies<int, DateTime>();
            movie2.Name = "movie1";
            movie2.Director = "dir1";
            movie2.ReleaseDate = DateTime.Now;
            movie2.Rate = 1;
        }
    }

    class Movies<TRate, TReleaseDate>
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public TReleaseDate ReleaseDate { get; set; }
        public TRate Rate { get; set; }
    }
}
