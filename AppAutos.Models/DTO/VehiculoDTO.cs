using AppAutos.Models;
using System.ComponentModel.DataAnnotations;

namespace ABM.AppAutos.BE.Models.DTO
{
    public class VehiculoDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Anio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Puertas { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Potencia { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Kilometros { get; set; }


        //////////////////////////////////////////////////////
        // Foreing Keys


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int MarcaId { get; set; }
        public MarcaDTO Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int TipoId { get; set; }
        public TipoDTO Tipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int ColorId { get; set; }
        public ColorDTO Color { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int CombustibleId { get; set; }
        public CombustibleDTO Combustible { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int PaisId { get; set; }
        public PaisDTO Pais { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? SeguroId { get; set; }
        public SeguroDTO Seguro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int EstadoId { get; set; }
        public EstadoDTO Estado { get; set; }
    }
}
