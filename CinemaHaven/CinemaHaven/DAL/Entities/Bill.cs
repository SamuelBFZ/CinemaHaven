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
        public User FullName { get; set; }
        public User Email { get; set; }
        public Movie Product { get; set; }
        public DateTime Date { get; set; }
        public PaymentType Type { get; set; }
        public float Total { get; set; }
        public string Term { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        #endregion

        #region Connections
        public Pay Pay { get; set; }
        public Guid PayId { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
        #endregion
    }
}
