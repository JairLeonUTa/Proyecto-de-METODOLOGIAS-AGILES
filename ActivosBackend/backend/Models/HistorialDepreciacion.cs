using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivosBackend.Models
{
    public class HistorialDepreciacion
    {
        [Key]
        public int IdHistorial { get; set; }
        
        public int IdActivo { get; set; }
        [ForeignKey("IdActivo")]
        public Activo? Activo { get; set; }
        
        public DateTime FechaCalculo { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorDepreciado { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorResidual { get; set; }
    }
}