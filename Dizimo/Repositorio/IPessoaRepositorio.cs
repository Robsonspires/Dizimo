using Dizimo.Enums;
using Dizimo.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dizimo.Repositorio
{
    public interface IPessoaRepositorio
    {
        PessoaModel PessoaListarPorId(int id);

        List<PessoaModel> PessoaBuscarTodos();

        PessoaModel PessoaAdicionar(PessoaModel pessoa);

        PessoaModel PessoaAtualizar(PessoaModel pessoa);

        bool PessoaApagar(int id);

    }
}
