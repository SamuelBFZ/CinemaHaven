using CinemaHaven.DAL;
using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaHaven.Domain.Services
{
    public class PayMethodService : IPayMethodService
    {
        public readonly DatabaseContext _context;

        public PayMethodService(DatabaseContext context)
        {
            _context = context;
        }        

        public async Task<IEnumerable<PaymentMethod>> GetPayMethodsAsync()
        {
            var payMeth = await _context.PaymentMethods.ToListAsync();

            return payMeth;
        }

        public async Task<PaymentMethod> GetPayMethodByIdAsync(Guid id)
        {
            try
            {
                var payMeth = await _context.PaymentMethods.FirstOrDefaultAsync(pm => pm.Id == id);

                return payMeth;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<PaymentMethod> CreatePayMethodAsync(PaymentMethod payMeth)
        {
            try
            {
                payMeth.Id = Guid.NewGuid();
                _context.PaymentMethods.Add(payMeth);

                await _context.SaveChangesAsync();

                return payMeth;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<PaymentMethod> EditPayMethodAsync(PaymentMethod payMeth)
        {
            try
            {
                _context.PaymentMethods.Update(payMeth);
                await _context.SaveChangesAsync();

                return payMeth;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<PaymentMethod> DeletePayMethodAsync(Guid id)
        {
            try
            {
                var payMeth = await GetPayMethodByIdAsync(id);

                if(payMeth == null)
                {
                    return null;
                }

                _context.PaymentMethods.Remove(payMeth);
                await _context.SaveChangesAsync();

                return payMeth;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }






    }
}
