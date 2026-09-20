using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivosBackend.Models
{
    public class Activo
    {
        [Key]
        public int IdActivo { get; set; }
        [Required]
        public string NombreActivo { get; set; }
        public string? Descripcion { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorInicial { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public CategoriaActivo? Categoria { get; set; }
        
        public string Estado { get; set; } = "Activo";
    }
}