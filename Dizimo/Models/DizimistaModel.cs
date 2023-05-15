using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

#nullable disable

namespace Dizimo.Models
{
    public class DizimistaModel
    {
        [Key, NotNull]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Entre com a data de nascimetno.")]
        public DateTime DataNascimento { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
