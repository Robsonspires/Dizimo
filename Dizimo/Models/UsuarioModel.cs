using Dizimo.Helper;
using Dizimo.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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

        
        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
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
