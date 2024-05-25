using System.ComponentModel.DataAnnotations;

namespace CinemaHaven.DAL.Entities
{
    public class PaymentMethod
    {
        #region Attribute
        [Required]
        [Key]
        public virtual Guid Id { get; set; }

        [Display(Name = "Número de Tarjeta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(20, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string CardNumber { get; set; }

        [Display(Name = "Fecha de Caducidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string ExpirationDate { get; set; } // Formato MM/YY

        [Display(Name = "Código de Seguridad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(4, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string SecurityCode { get; set; }

        [Display(Name = "Nombre del Titular")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string CardHolderName { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string Address { get; set; }

        [Display(Name = "Código Postal")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo {0} puede tener como máximo {1} caracteres")]
        public string PostalCode { get; set; }
        #endregion

        #region Connections
        public ICollection<Pay>? pays { get; set; }

        public User? User { get; set; }
        public Guid? UserId { get; set; }
        #endregion
    }
}
