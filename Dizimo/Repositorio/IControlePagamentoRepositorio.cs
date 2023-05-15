using Dizimo.Models;

namespace Dizimo.Repositorio
{
    public interface IControlePagamentoRepositorio
    {
        ControlePagamentoModel ListarCPPorId(int id);

        List<ControlePagamentoModel> BuscarCPTodos();
    }
}
