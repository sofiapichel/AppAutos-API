using System.ComponentModel.DataAnnotations;

namespace ABM.AppAutos.BE.Models.DTO
{
    public class PaisDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30)]       
        public string Nombre { get; set; }
    }
}
