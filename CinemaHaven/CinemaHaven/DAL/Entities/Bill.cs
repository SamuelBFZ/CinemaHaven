using CinemaHaven.Enums;
using System.ComponentModel.DataAnnotations;

namespace CinemaHaven.DAL.Entities
{
    public class Bill
    {
        #region Attributes
        [Required]
        [Key]
        public virtual Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public float Total { get; set; }
        public string Term { get; set; }
        public string PaymentMethod { get; set; }
        #endregion

        #region Connections

        public User User { get; set; }
        public Guid UserId { get; set; }
        #endregion
    }
}
