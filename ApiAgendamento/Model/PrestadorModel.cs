using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgendamento.Model
{
    [Table("Prestadores")]
    public class PrestadorModel
    {
        [Key]
        public int PrestadorId { get; set; }
        [Required]
        public UsuarioModel? UsuarioModel { get; set; }
        [Required]
        [StringLength(255)]
        public string? RazaoSocial { get; set; }
        [Required]
        [StringLength(255)]
        public string? NomeFantasia { get; set; }
        [Required]
        [StringLength(14)]
        public string? CpfCnpj { get; set; }
        [Required]
        [StringLength(255)]
        public string? Endereco { get; set; }
        [Required]
        [StringLength(8)]
        public string? Cep { get; set; }
        [Required]
        [StringLength(6)]
        public string? Numero { get; set; }
        [Required]
        [StringLength(255)]
        public string? Cidade { get; set; }
        [Required]
        [StringLength(255)]
        public string? Bairro { get; set; }
        [Required]
        [StringLength(255)]
        public string? Complemento { get; set; }
        [Required]     
        public char Tipo { get; set; }
    }
}
