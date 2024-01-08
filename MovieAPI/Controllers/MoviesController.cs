using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Repository;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public readonly IMoviesRepo _moviesRepo;

        public MoviesController(IMoviesRepo moviesRepo)
        {
            _moviesRepo = moviesRepo;
        }

        [HttpPost]  
        [Route("AddMovie")] 
        public IActionResult AddMovie(Movies movie)
        {
            try
            {

                _moviesRepo.AddMovie(movie);
                return StatusCode(200, "Added");

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetAllMovie")]
        public IActionResult GetAllMovies()
        {
            try
            {

                var m=_moviesRepo.GetAllMovies();
                return StatusCode(200, m);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetMovieByName/{name}")]
        public IActionResult GetMovieByName(string name)
        {
            var m=_moviesRepo.GetMovieByName(name);
            return StatusCode(200,m);
        }
        [HttpGet]
        [Route("GetMoviesByActor/{name}")]
        public IActionResult GetMoviesByActor(string name)
        {
            var m = _moviesRepo.GetMoviesByActor(name);
            return StatusCode(200, m);
        }
        [HttpGet]
        [Route("GetMoviesByReleaseYear/{year}")]
        public IActionResult GetMoviesByReleaseYear(int year)
        {
            var m = _moviesRepo.GetMoviesByReleaseYear(year);
            return StatusCode(200,m);
        }
        [HttpGet]
        [Route("GetMoviesByDirector/{name}")]
        public IActionResult GetMoviesByDirector(string name)
        {
            var m = _moviesRepo.GetMoviesByDirector(name);
            return StatusCode(200,m);
        }
    }
}
