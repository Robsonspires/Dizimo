using Dizimo.Data;
using Dizimo.Models;

namespace Dizimo.Repositorio
{
    public class ComunidadeRepositorio : IComunidadeRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ComunidadeRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ComunidadeModel> ComunidadeBuscarTodos()
        {
            return _bancoContext.Comunidades.ToList();
        }

        public List<ComunidadeModel> comunidadeList()
        {
            return _bancoContext.Comunidades.ToList();
        }
    }
}
