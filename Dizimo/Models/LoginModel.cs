using System.ComponentModel.DataAnnotations;

namespace Dizimo.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login.")]
        public String? Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public String? Senha { get; set; }
    }
}
