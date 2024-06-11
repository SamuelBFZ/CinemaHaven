using CinemaHaven.DAL.Entities;

namespace CinemaHaven.Domain.Interfaces
{
    public interface IPayService
    {
        Task<IEnumerable<Pay>> GetPaysAsync();
        Task<Pay> GetPayByIdAsync(Guid id);
        Task<Pay> CreatePayAsync(Pay pay);
        Task<Pay> EditPayAsync(Pay pay);
        Task<Pay> DeletePayAsync(Guid id);
    }
}
