using CinemaHaven.DAL.Entities;

namespace CinemaHaven.Domain.Interfaces
{
    public interface IPayMethodService
    {
        Task<IEnumerable<PaymentMethod>> GetPayMethodsAsync();
        Task<PaymentMethod> GetPayMethodByIdAsync(Guid id);
        Task<PaymentMethod> CreatePayMethodAsync(PaymentMethod payMeth);
        Task<PaymentMethod> EditPayMethodAsync(PaymentMethod payMeth);
        Task<PaymentMethod> DeletePayMethodAsync(Guid id);
    }
}
