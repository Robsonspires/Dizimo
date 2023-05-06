using Dizimo.Filters;
using Dizimo.Models;
using Dizimo.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Dizimo.Controllers
{
    [PaginaparaUsuarioLogado]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public IActionResult Index()
        {
            List<PessoaModel> pessoas = _pessoaRepositorio.PessoaBuscarTodos();
            return View(pessoas);
        }
        public IActionResult PessoaCriar()
        {
            return View();
        }
        public IActionResult PessoaEditar(int id)
        {
            PessoaModel pessoa = _pessoaRepositorio.PessoaListarPorId(id);
            return View(pessoa);
        }
        public IActionResult PessoaApagarConfirmacao(int id)
        {
            PessoaModel pessoa = _pessoaRepositorio.PessoaListarPorId(id);
            return View(pessoa);
        }

        public IActionResult PessoaApagar(int id)
        {
            try
            {
                bool apagado = _pessoaRepositorio.PessoaApagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Pessoa Apagada com sucesso.";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar o cadastro.";
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar o cadastro, mais detalhes do erro: {erro.Message}.";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public IActionResult PessoaCriar(PessoaModel pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pessoaRepositorio.PessoaAdicionar(pessoa);
                    TempData["MensagemSucesso"] = "Cadastrado efetuado com sucesso.";
                    return RedirectToAction("Index");
                }
                return View(pessoa);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar o cadastro, tente novamente, detalhe do erro: {erro.Message}.";
                return RedirectToAction("Index");
            }
        }

       
    }
}
