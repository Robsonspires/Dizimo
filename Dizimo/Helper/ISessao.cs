using Dizimo.Models;

namespace Dizimo.Helper
{
    public interface ISessao
    {
         void CriarSessaoDoUsuario(UsuarioModel usuario);

         void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaodoUsuario();
    }
}
