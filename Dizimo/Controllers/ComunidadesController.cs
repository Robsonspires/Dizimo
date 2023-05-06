using Dizimo.Data;
using Dizimo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dizimo.Controllers
{
    public class ComunidadesController : Controller
    {
        private readonly BancoContext _bancoContext;

        public ComunidadesController(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        // GET: ComunidadesController
        public ActionResult Index()
        {
            return View(_bancoContext.Comunidades.ToList());
        }

        // GET: ComunidadesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ComunidadesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComunidadesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ComunidadeModel collection)
        {
            try
            {
                _bancoContext.Comunidades.Add(collection);
                _bancoContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ComunidadesController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_bancoContext.Comunidades.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: ComunidadesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ComunidadeModel collection)
        {
            try
            {
                _bancoContext.Comunidades.Update(collection);
                _bancoContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ComunidadesController/Delete/5
        public ActionResult Delete(int id)
        {
            _bancoContext.Comunidades.Remove(_bancoContext.Comunidades.Where(a => a.Id == id).FirstOrDefault());
            _bancoContext.SaveChanges();
            return View();
        }

        // POST: ComunidadesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
