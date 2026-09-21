using System.ComponentModel.DataAnnotations;

namespace ActivosBackend.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        [Required]
        public string NombreRol { get; set; }
    }
}