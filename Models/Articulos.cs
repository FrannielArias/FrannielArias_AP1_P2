using System.ComponentModel.DataAnnotations;

namespace FrannielArias_AP1_P2.Models
{
    public class Articulos
    {
        [Key]
        public int Articuloid {  get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z/s]+$", ErrorMessage ="Este campo es obligatorio")]
        public string? Descripcion { get; set; }

        [Required]
        public double precio { get; set; }

    }
}
