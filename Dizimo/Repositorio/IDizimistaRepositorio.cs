using Dizimo.Enums;
using Dizimo.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dizimo.Repositorio
{
    public interface IDizimistaRepositorio
    {
        DizimistaModel DizimistaListarPorId(int id);

        List<DizimistaModel> DizimistaBuscarTodos();

        DizimistaModel DizimistaAdicionar(DizimistaModel dizimista);

        DizimistaModel DizimistaAtualizar(DizimistaModel dizimista);

        bool DizimistaApagar(int id);

    }
}
