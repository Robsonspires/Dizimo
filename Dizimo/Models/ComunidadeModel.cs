using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dizimo.Models
{
    public class ComunidadeModel
    {
        [Key, NotNull]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da comunidade.")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFundacao { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }
}
