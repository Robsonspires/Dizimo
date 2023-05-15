using Dizimo.Data;
using Dizimo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#nullable disable

namespace Dizimo.Repositorio
{
    public class ControlePagamentoRepositorio : IControlePagamentoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ControlePagamentoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public List<ControlePagamentoModel> BuscarCPTodos()
        {
            // return _bancoContext.ControlePagamentos.Include(c => c.comunidadecp).ToList();
            return _bancoContext.ControlePagamentos.Include(c => c.comunidadecp).Include(d => d.dizimistacp).ToList();
            //return _bancoContext.ControlePagamentos.ToList();
        }

        public ControlePagamentoModel ListarCPPorId(int id)
        {
            //var controlePagamento = new ControlePagamentoModel();
            //controlePagamento = _bancoContext.ControlePagamentos.Include(c => c.comunidadecp).Include(d => d.dizimistacp).FirstOrDefault(x => x.Id == id);
            //return controlePagamento;
            return _bancoContext.ControlePagamentos.Include(c => c.comunidadecp).Include(d => d.dizimistacp).FirstOrDefault(x => x.Id == id);
        }
    }
}
