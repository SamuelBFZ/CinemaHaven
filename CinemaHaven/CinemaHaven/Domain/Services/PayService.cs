using CinemaHaven.DAL;
using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaHaven.Domain.Services
{
    public class PayService : IPayService
    {
        private readonly DatabaseContext _context;

        public PayService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pay>> GetPaysAsync()
        {
            var pay = await _context.Pays.ToListAsync();

            return pay;
        }

        public async Task<Pay> GetPayByIdAsync(Guid id)
        {
            try
            {
                var pay = await _context.Pays.FirstOrDefaultAsync(p => p.Id == id);

                return pay;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Pay> CreatePayAsync(Pay pay)
        {
            try
            {
                pay.Id = Guid.NewGuid();
                _context.Pays.Add(pay);

                await _context.SaveChangesAsync();

                return pay;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Pay> EditPayAsync(Pay pay)
        {
            try
            {
                _context.Pays.Update(pay);
                await _context.SaveChangesAsync();

                return pay;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Pay> DeletePayAsync(Guid id)
        {
            try
            {
                var pay = await GetPayByIdAsync(id);

                if(pay == null)
                {
                    return null;
                }

                _context.Pays.Remove(pay);
                await _context.SaveChangesAsync();

                return pay;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

    }
}
