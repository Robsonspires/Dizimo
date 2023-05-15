using Dizimo.Helper;
using Dizimo.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Configuration;

#nullable disable

namespace Dizimo.Models
{
    public class UsuarioModel
    {
        [Key, NotNull]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome completo do usuario.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuário.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o perfil do usuário.")]
        public PerfilEnum Perfil { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DataAtualizacao { get; set; }
        
        [DefaultValue(0)]
        public int ComunidadeId { get; set; }
        
        public ComunidadeModel comunidade { get; set; }

        public List<ComunidadeModel> ListaComunidades { get; set; }


        public bool SenhaValida(string senha)
        {
            // 2ba733e086e7c2f98b3a193782146ad21060c051 -> 1340
            // 8cb2237d0679ca88db6464eac60da96345513964 -> 12345
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

        public void SetNovaSenha(string novaSenha)
        {
            Senha = novaSenha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0,8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }
    }
}
