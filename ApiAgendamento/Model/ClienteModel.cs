using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgendamento.Model
{
    [Table("Clientes")]
    public class ClienteModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [StringLength(255)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string? Cpf { get; set; }
        [Required]
        [StringLength(20)]
        public string? Celular { get; set; }
    }
}
