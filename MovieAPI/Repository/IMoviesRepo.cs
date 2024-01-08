using MovieAPI.Models;

namespace MovieAPI.Repository
{
    public interface IMoviesRepo
    {
        void AddMovie(Movies movie);
        List<Movies> GetAllMovies();
        Movies GetMovieByName(string MovieName);
        List<Movies> GetMoviesByActor(string ActorName);
        List<Movies> GetMoviesByReleaseYear(int Year);
        List<Movies> GetMoviesByDirector(string DirectorName);
    }
}
