using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrannielArias_AP1_P2.Models
{
    public class CombosDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cantidad { get; set; }

        [Required]
        public double Costo {  get; set; }
        public int ComboId {  get; set; }
        public int ArticuloId { get; set; }

        [ForeignKey("ComboId")]
        public Combos? Combos { get; set; }

        [ForeignKey("ArticuloId")]
        public Articulos? Articulos { get; set; }
    }
}
