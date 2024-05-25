using CinemaHaven.DAL.Entities;
using System.Diagnostics.Metrics;

namespace CinemaHaven.Domain.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie> EditMovieAsync(Movie movie);
        Task<Movie> DeleteMovieAsync(Guid id);
    }
}
