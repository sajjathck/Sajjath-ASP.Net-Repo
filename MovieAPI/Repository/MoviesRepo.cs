using MovieAPI.Models;

namespace MovieAPI.Repository
{
    public class MoviesRepo : IMoviesRepo
    {
        List<Movies> movies = new List<Movies>()
        {
            new Movies(){ MovieId=1,MovieName="Her",Lang="English",ReleaseYear=2018,Actor="JOAQIN" ,Director="Steve" }
        };
        public void AddMovie(Movies movie)
        {
            try
            {

                movie.MovieId = new Random().Next(100, 1000);
                movies.Add(movie);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movies> GetAllMovies()
        {
            try
            {
                return movies;

            }
            catch (Exception)
            {

                throw;
            }        
        }

        public Movies GetMovieByName(string MovieName)
        {
            try
            {

                Movies movie = movies.SingleOrDefault(x => x.MovieName == MovieName);
                if (movie != null)
                {
                    return movie;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movies> GetMoviesByActor(string ActorName)
        {
            try
            {

                var movie = (from x in movies
                             where x.Actor == ActorName
                             select x).ToList();
                return movie;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movies> GetMoviesByDirector(string DirectorName)
        {
            try
            {

                var movie = (from x in movies
                             where x.Director == DirectorName
                             select x).ToList();
                return movie;
                //var m=(movies.Where(x=>x.Director == DirectorName).ToList());

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movies> GetMoviesByReleaseYear(int Year)
        {
            try
            {

                var movie = (from x in movies
                             where x.ReleaseYear == Year
                             select x).ToList();
                return movie;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
