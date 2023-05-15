using Dizimo.Data;
using Dizimo.Models;

namespace Dizimo.Repositorio
{
    public class DizimistaRepositorio : IDizimistaRepositorio
    {
        private readonly BancoContext _dizimistaBancoContext;

        public DizimistaRepositorio(BancoContext bancoContext)
        {
            _dizimistaBancoContext = bancoContext;
        }

        public DizimistaModel DizimistaListarPorId(int id)
        {
            return _dizimistaBancoContext.Dizimistas.FirstOrDefault(x => x.Id == id);
        }

        public List<DizimistaModel> DizimistaBuscarTodos()
        {
            return _dizimistaBancoContext.Dizimistas.ToList();
        }

        public DizimistaModel DizimistaAdicionar(DizimistaModel dizimista)
        {
            dizimista.DataCadastro = DateTime.Now;
            
            _dizimistaBancoContext.Dizimistas.Add(dizimista);
            _dizimistaBancoContext.SaveChanges();
            return dizimista;
        }

        public DizimistaModel DizimistaAtualizar(DizimistaModel dizimista)
        {
            DizimistaModel DizimistaDB = DizimistaListarPorId(dizimista.Id);

            if (DizimistaDB == null) throw new System.Exception("Houve um erro na atualização do cadastro.");
            DizimistaDB.Nome = dizimista.Nome;
            DizimistaDB.DataNascimento = dizimista.DataNascimento;
            DizimistaDB.CpfCnpj = dizimista.CpfCnpj;
            DizimistaDB.Email = dizimista.Email;
            DizimistaDB.Fone= dizimista.Fone;
            DizimistaDB.CEP= dizimista.CEP;
            DizimistaDB.Endereco = dizimista.Endereco;
            DizimistaDB.Complemento = dizimista.Complemento;
            DizimistaDB.Bairro = dizimista.Bairro;
            DizimistaDB.Cidade = dizimista.Cidade;
            DizimistaDB.UF = dizimista.UF;
            DizimistaDB.Email = dizimista.Email;
            DizimistaDB.DataAtualizacao = DateTime.Now;

            _dizimistaBancoContext.Dizimistas.Update(DizimistaDB);
            _dizimistaBancoContext.SaveChanges();

            return DizimistaDB;
        }

        public bool DizimistaApagar(int id)
        {
            DizimistaModel dizimistaDB = DizimistaListarPorId(id);

            if (dizimistaDB == null) throw new System.Exception("Houve um erro na deleção do dizimista!");
            _dizimistaBancoContext.Dizimistas.Remove(dizimistaDB);
            _dizimistaBancoContext.SaveChanges();

            return true;
        }
    }
}
