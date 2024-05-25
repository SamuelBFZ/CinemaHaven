using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace CinemaHaven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesAsync()
        {
            var movies = await _movieService.GetMoviesAsync();

            if (movies == null || !movies.Any())
            {
                return NotFound();
            }

            return Ok(movies);
        }

        [HttpGet, ActionName("Get")]
        [Route("GetById/{id}")]
        public async Task<ActionResult<Movie>> GetMovieByIdAsync(Guid id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost, ActionName("Create")]
        [Route("Create")]
        public async Task<ActionResult<Movie>> CreateMovieAsync(Movie movie)
        {
            var newMovie = await _movieService.CreateMovieAsync(movie);

            if (newMovie == null) return NotFound();

            return Ok(newMovie);
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<Movie>> EditMovieAsync(Movie movie)
        {
            var editedMovie = await _movieService.EditMovieAsync(movie);

            if (editedMovie == null) return NotFound();

            return Ok(editedMovie);
        }

        [HttpDelete, ActionName("Delete")]
        [Route("Delete")]
        public async Task<ActionResult<Movie>> DeleteMovieAsync(Guid id)
        {
            if (id == null) return BadRequest();

            var deletedMovie = await _movieService.DeleteMovieAsync(id);

            if (deletedMovie == null) return NotFound();

            return Ok(deletedMovie);
        }
    }
}
