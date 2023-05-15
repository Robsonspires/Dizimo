using Dizimo.Filters;
using Dizimo.Models;
using Dizimo.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Dizimo.Controllers
{
    [PaginaparaUsuarioLogado]
    public class DizimistaController : Controller
    {
        private readonly IDizimistaRepositorio _dizimistaRepositorio;
        public DizimistaController(IDizimistaRepositorio dizimistaRepositorio)
        {
            _dizimistaRepositorio = dizimistaRepositorio;
        }
        public IActionResult Index()
        {
            List<DizimistaModel> dizimistas = _dizimistaRepositorio.DizimistaBuscarTodos();
            return View(dizimistas);
        }
        public IActionResult DizimistaCriar()
        {
            return View();
        }
        public IActionResult DizimistaEditar(int id)
        {
            DizimistaModel dizimista = _dizimistaRepositorio.DizimistaListarPorId(id);
            return View(dizimista);
        }
        public IActionResult DizimistaApagarConfirmacao(int id)
        {
            DizimistaModel dizimista = _dizimistaRepositorio.DizimistaListarPorId(id);
            return View(dizimista);
        }

        public IActionResult DizimistaApagar(int id)
        {
            try
            {
                bool apagado = _dizimistaRepositorio.DizimistaApagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Dizimista Apagada com sucesso.";
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
        public IActionResult DizimistaCriar(DizimistaModel dizimista)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dizimistaRepositorio.DizimistaAdicionar(dizimista);
                    TempData["MensagemSucesso"] = "Cadastrado efetuado com sucesso.";
                    return RedirectToAction("Index");
                }
                return View(dizimista);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar o cadastro, tente novamente, detalhe do erro: {erro.Message}.";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult DizimistaEditar(DizimistaModel dizimista)
        {
            _dizimistaRepositorio.DizimistaAtualizar(dizimista);
            TempData["MensagemSucesso"] = "Dizimista Alterado com sucesso.";
            return RedirectToAction("index");
        }
    }
}
