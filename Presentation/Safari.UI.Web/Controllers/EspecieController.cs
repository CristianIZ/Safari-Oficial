using Safari.Entities;
using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safari.UI.Web.Controllers
{
    public class EspecieController : Controller
    {
        // GET: Especie
        public ActionResult Index()
        {
            var ep = new EspecieProcess();
            var lista = ep.Listar();
            return View("Index", lista);
        }

        // GET: Especie/Details/5
        public ActionResult Details(int id)
        {
            var ep = new EspecieProcess();
            var especie = new Especie() { Id = id };
            especie = ep.ObtenerPorId(especie);

            return View(especie);
        }

        // GET: Especie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especie/Create
        [HttpPost]
        public ActionResult Create(Especie especieData)
        {
            try
            {
                var ep = new EspecieProcess();
                var especie = ep.Agregar(especieData);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Edit/5
        public ActionResult Edit(int id)
        {
            var ep = new EspecieProcess();
            var especie = new Especie() { Id = id };
            especie = ep.ObtenerPorId(especie);

            return View("Edit", especie);
        }

        // POST: Especie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Especie especie)
        {
            try
            {
                var ep = new EspecieProcess();
                especie.Id = id;
                ep.Editar(especie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Delete/5
        public ActionResult Delete(int id)
        {
            var ep = new EspecieProcess();
            var especie = new Especie() { Id = id };
            especie = ep.ObtenerPorId(especie);

            return View("Delete", especie);
        }

        // POST: Especie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Especie especie)
        {
            try
            {
                var ep = new EspecieProcess();
                especie.Id = id;
                ep.Borrar(especie);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
