﻿using System.ComponentModel.DataAnnotations;

namespace CinemaHaven.DAL.Entities
{
    public class Movie
    {
        #region Attributes
        [Required]
        [Key]
        public virtual Guid Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Sinopsis")]
        [MaxLength(250, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Reparto")]
        [MaxLength(500, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string Cast { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Director")]
        [MaxLength(30, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string Director { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Duracion")]
        [MaxLength(10, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]//2h 20m
        public string Duration { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estreno")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public string Release { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio compra")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public float Buy { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio Alquiler")]
        [MaxLength(50, ErrorMessage = "El campo {0} puede tener maximo {1} caracteres")]
        public float Rent { get; set; }
        #endregion
    }
}
