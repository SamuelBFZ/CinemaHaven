using CinemaHaven.Enums;
using System.ComponentModel.DataAnnotations;

namespace CinemaHaven.DAL.Entities
{
    public class User
    {
        #region Attributes
        [Required]
        [Key]
        public virtual Guid Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El campo {0} no es una dirección de correo electrónico válida")]
        [MaxLength(254, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Password { get; set; }

        [Display(Name = "Gustos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} puede tener como maximo {1} caracteres")]
        public string Gustos { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public UserRole UserRole { get; set; }
        #endregion

        #region Connections
        public ICollection<Bill> bills { get; set; }

        public ICollection<PaymentMethod> paymentMethods { get; set; }
        #endregion
    }
}
