using CinemaHaven.Enums;
using System.ComponentModel.DataAnnotations;

namespace CinemaHaven.DAL.Entities
{
    public class Pay
    {
        [Required]
        [Key]
        public virtual Guid Id { get; set; }

        [Display(Name = "Tipo de Pago")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public PaymentType Tipo { get; set; }

        [Display(Name = "Plazo")]
        public DateOnly? Plazo { get; set; }
    }
}
