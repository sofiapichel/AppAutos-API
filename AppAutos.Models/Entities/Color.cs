﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAutos.Models
{
    [Table(name: "Colores")]
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Código De Color")]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Nombre del color:")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
