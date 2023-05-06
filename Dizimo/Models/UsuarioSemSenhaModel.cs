using Dizimo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Dizimo.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do usuario.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o login do usuário.")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Digite o e-mail do contato.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido.")]
        public string Email { get; set; }
        public PerfilEnum Perfil { get; set; }

        //public ComunidadeModel Comunidade { get; set; }
       
        //public int ComunidadeId { get; set; }
        
       // public List<ComunidadeModel> ListaComunidades { get; set; }

    }
}
