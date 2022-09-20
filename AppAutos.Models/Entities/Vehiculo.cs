using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAutos.Models
{
    [Table(name: "vehiculos")]
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Código De Vehiculo")]
        public int Id { get; set; }

        [StringLength(50)] 
        [Column("modelo")]
        [Display(Name = "Modelo")]
        [DataType(DataType.Text)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("precio", TypeName = "money")]
        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]

        public decimal Precio { get; set; }

        [StringLength(4)]
        [Column("anio", TypeName = "char(4)")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Año")]
        [DataType(DataType.Text)]
        public string Anio { get; set; }

        [Column("puertas", TypeName = "tinyint")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Puertas")]
        public int Puertas { get; set; }

        [Column("potencia", TypeName = "smallint")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Potencia (CV)")]
        public int Potencia { get; set; }

        [Column("kilometros")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "KM")]
        public int Kilometros { get; set; }


        //////////////////////////////////////////////////////
        // Foreing Keys
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_marca")]
        [Column("id_marca")]
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_tipo")]
        [Column("id_tipo")]
        [Display(Name = "Tipo")]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_color")]
        [Column("id_color")]
        [Display(Name = "Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_combustible")]
        [Column("id_combustible")]
        [Display(Name = "Combustible")]
        public int CombustibleId { get; set; }
        public Combustible Combustible { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_pais")]
        [Column("id_pais")]
        [Display(Name = "País")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [ForeignKey("id_seguro")]
        [Column("id_seguro")]
        [Display(Name = "Seguro")]
        public int? SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("id_estado")]
        [Column("id_estado")]
        [Display(Name = "Estado")]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
