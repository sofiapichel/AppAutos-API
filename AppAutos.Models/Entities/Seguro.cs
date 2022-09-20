using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAutos.Models
{
    [Table(name: "Seguros")]
    public class Seguro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Código de seguro")]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Nombre de seguro:")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
