using System.ComponentModel.DataAnnotations;

namespace ActivosBackend.Models
{
    public class CategoriaActivo
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required]
        public string NombreCategoria { get; set; }
        public int VidaUtilAnios { get; set; }
    }
}