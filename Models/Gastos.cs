
using System.ComponentModel.DataAnnotations;

namespace FinanzasApp.Models
{
    public class Gastos
    {
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; } = null!;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor que cero.")]
        public double Monto { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required]

        public string Categoria { get; set; } = null!;

    }
}
