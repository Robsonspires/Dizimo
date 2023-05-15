using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dizimo.Data;
using Dizimo.Models;
using Dizimo.Repositorio;

#nullable disable

namespace Dizimo.Controllers
{
    public class ControlePagamentoController : Controller
    {
        private readonly BancoContext _bancoContext;
        private readonly IControlePagamentoRepositorio _controlePagamentoRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IDizimistaRepositorio _dizimistaRepositorio;

        public ControlePagamentoController(IUsuarioRepositorio usuarioRepositorio, 
                                           IDizimistaRepositorio dizimistaRepositorio,
                                           IControlePagamentoRepositorio controlePagamentoRepositorio,
                                           BancoContext context)
        {
            _bancoContext = context;
            _usuarioRepositorio = usuarioRepositorio;
            _dizimistaRepositorio = dizimistaRepositorio;
            _controlePagamentoRepositorio = controlePagamentoRepositorio;
        }

        // GET: ControlePagamento
        public async Task<IActionResult> Index()
        {
            List<ControlePagamentoModel> controlePagamentos = _controlePagamentoRepositorio.BuscarCPTodos();
            return View(controlePagamentos);

            //return _bancoContext.ControlePagamentos != null ? 
            //              View(await _bancoContext.ControlePagamentos.ToListAsync()) :
            //              Problem("Entity set 'BancoContext.ControlePagamentos'  is null.");
        }

        // GET: ControlePagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _bancoContext.ControlePagamentos == null)
            {
                return NotFound();
            }

            var controlePagamentoModel = await _bancoContext.ControlePagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (controlePagamentoModel == null)
            {
                return NotFound();
            }

            return View(controlePagamentoModel);
        }

        // GET: ControlePagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ControlePagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DizimistaId,ComunidadeId,UsuarioID,MesAno,Janeiro,Fevereiro,Marco,Abril,Maio,Junho,Julho,Agosto,Setembro,Outubro,Novembro,Dezembro,Atualizacao")] ControlePagamentoModel controlePagamentoModel)
        {
            if (ModelState.IsValid)
            {
                _bancoContext.Add(controlePagamentoModel);
                await _bancoContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(controlePagamentoModel);
        }

        public IControlePagamentoRepositorio Get_controlePagamentoRepositorio()
        {
            return _controlePagamentoRepositorio;
        }

        // GET: ControlePagamento/Edit/5
        public IActionResult Edit(int id)
        {
            ControlePagamentoModel controlePagamento = new ControlePagamentoModel();
            controlePagamento = _controlePagamentoRepositorio.ListarCPPorId(id);
            controlePagamento.ListaPagamentoComunidades = _bancoContext.Comunidades.ToList();
            return View(controlePagamento);
        }

        // POST: ControlePagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DizimistaId,ComunidadeId,UsuarioID,MesAno,Janeiro,Fevereiro,Marco,Abril,Maio,Junho,Julho,Agosto,Setembro,Outubro,Novembro,Dezembro,Atualizacao")] ControlePagamentoModel controlePagamentoModel)
        {
            if (id != controlePagamentoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bancoContext.Update(controlePagamentoModel);
                    await _bancoContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ControlePagamentoModelExists(controlePagamentoModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(controlePagamentoModel);
        }

        // GET: ControlePagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _bancoContext.ControlePagamentos == null)
            {
                return NotFound();
            }

            var controlePagamentoModel = await _bancoContext.ControlePagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (controlePagamentoModel == null)
            {
                return NotFound();
            }

            return View(controlePagamentoModel);
        }

        // POST: ControlePagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_bancoContext.ControlePagamentos == null)
            {
                return Problem("Entity set 'BancoContext.ControlePagamentos'  is null.");
            }
            var controlePagamentoModel = await _bancoContext.ControlePagamentos.FindAsync(id);
            if (controlePagamentoModel != null)
            {
                _bancoContext.ControlePagamentos.Remove(controlePagamentoModel);
            }
            
            await _bancoContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ControlePagamentoModelExists(int id)
        {
          return (_bancoContext.ControlePagamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
