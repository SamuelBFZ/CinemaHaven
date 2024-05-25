using CinemaHaven.DAL;
using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;

namespace CinemaHaven.Domain.Services
{
    public class MovieService : IMovieService
    {
        private readonly DatabaseContext _context;

        public MovieService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            var movie = await _context.Movies.ToListAsync();

            return movie;
        }

        public async Task<Movie> GetMovieByIdAsync(Guid id)
        {
            try
            {
                var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

                return movie;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Movie> CreateMovieAsync(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
                return movie;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Movie> EditMovieAsync(Movie movie)
        {
            try
            {
                _context.Movies.Update(movie);
                await _context.SaveChangesAsync();

                return movie;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Movie> DeleteMovieAsync(Guid id)
        {
            try
            {
                var movie = await GetMovieByIdAsync(id);

                if (movie != null)
                {
                    return null;
                }

                return movie;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

    }
}
