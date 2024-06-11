using CinemaHaven.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CinemaHaven.DAL.Entities
{
    public class Pay
    {
        #region Attributes
        [Required]
        [Key]
        public virtual Guid Id { get; set; }

        [Display(Name = "Tipo de Pago")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public PaymentType Type { get; set; }

        [Display(Name = "Plazo")]
        public string Term { get; set; }
        #endregion

        #region Connections
        [JsonIgnore]
        public Movie? Movie { get; set; }
        public Guid? MovieId { get; set; }

        [JsonIgnore]
        public PaymentMethod? PaymentMethod { get; set; }
        public Guid? PaymentMethodId { get; set; }

        #endregion
    }
}
