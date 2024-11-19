using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace FrannielArias_AP1_P2.Models
{
    public class Combos
    {
        [Key]
        public int ComboId { get; set; }

        public DateTime Fecha {  get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Descricion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Vendido { get; set; }
    }
}
