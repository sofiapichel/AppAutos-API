using System.ComponentModel.DataAnnotations;

namespace ABM.AppAutos.BE.Models.DTO
{
    public class TipoDTO
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]      
        public string Nombre { get; set; }
    }
}
