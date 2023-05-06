using Dizimo.Data;
using Dizimo.Models;

namespace Dizimo.Repositorio
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly BancoContext _pessoaBancoContext;

        public PessoaRepositorio(BancoContext bancoContext)
        {
            _pessoaBancoContext = bancoContext;
        }

        public PessoaModel PessoaListarPorId(int id)
        {
            return _pessoaBancoContext.Pessoas.FirstOrDefault(x => x.Id == id);
        }

        public List<PessoaModel> PessoaBuscarTodos()
        {
            return _pessoaBancoContext.Pessoas.ToList();
        }

        public PessoaModel PessoaAdicionar(PessoaModel pessoa)
        {
            pessoa.DataCadastro = DateTime.Now;
            
            _pessoaBancoContext.Pessoas.Add(pessoa);
            _pessoaBancoContext.SaveChanges();
            return pessoa;
        }

        public PessoaModel PessoaAtualizar(PessoaModel pessoa)
        {
            PessoaModel pessoaDB = PessoaListarPorId(pessoa.Id);

            if (pessoaDB == null) throw new System.Exception("Houve um erro na atualização do cadastro.");
            pessoaDB.Nome = pessoa.Nome;
            pessoaDB.DataNascimento = pessoa.DataNascimento;
            pessoaDB.CpfCnpj = pessoa.CpfCnpj;
            pessoaDB.Email = pessoa.Email;
            pessoaDB.Fone= pessoa.Fone;
            pessoaDB.CEP= pessoa.CEP;
            pessoaDB.Endereco = pessoa.Endereco;
            pessoaDB.Complemento = pessoa.Complemento;
            pessoaDB.Bairro = pessoa.Bairro;
            pessoaDB.Cidade = pessoa.Cidade;
            pessoaDB.UF = pessoa.UF;
            pessoaDB.TipoPessoa = pessoa.TipoPessoa;
            pessoaDB.Email = pessoa.Email;
            pessoaDB.DataAtualizacao = DateTime.Now;

            _pessoaBancoContext.Pessoas.Update(pessoaDB);
            _pessoaBancoContext.SaveChanges();

            return pessoaDB;
        }

        public bool PessoaApagar(int id)
        {
            PessoaModel pessoaDB = PessoaListarPorId(id);

            if (pessoaDB == null) throw new System.Exception("Houve um erro na deleção da pessoa!");
            _pessoaBancoContext.Pessoas.Remove(pessoaDB);
            _pessoaBancoContext.SaveChanges();

            return true;
        }
    }
}
