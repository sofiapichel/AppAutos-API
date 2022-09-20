using System.ComponentModel.DataAnnotations;

namespace ABM.AppAutos.BE.Models.DTO
{
    public class MarcaDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}
