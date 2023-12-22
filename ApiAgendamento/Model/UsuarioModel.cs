using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgendamento.Model
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Login { get; set; }
        [Required]
        [StringLength(50)]
        public string? Senha { get; set; }
        public bool Tipo { get; set; }
        [Required]
        [StringLength(120)]
        public string? Email { get; set; }
    }
}
