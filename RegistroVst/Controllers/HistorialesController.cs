using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroVst.Data;
using RegistroVst.Models;

namespace RegistroVst.Controllers
{
    public class HistorialesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistorialesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Historial> listHistorial = _context.Historial;
            return View(listHistorial);
        }

        //Http Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Historial historial)
        {
            if (ModelState.IsValid)
            {
                _context.Historial.Add(historial);
                _context.SaveChanges();

                TempData["mensaje"] = "El Historial se ha registrado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Historial = _context.Historial.Find(id);
            if (Historial == null)
            {
                return NotFound();
            }
            return View(Historial);
        }

        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Historial historial)
        {
            if (ModelState.IsValid)
            {
                _context.Historial.Update(historial);
                _context.SaveChanges();

                TempData["mensaje"] = "El Historial se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var historial = _context.Historial.Find(id);
            if (historial == null)
            {
                return NotFound();
            }
            return View(historial);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteHistorial(int? id)
        {
            // Obtener el Historial por id
            var historial = _context.Historial.Find(id);
            if (historial == null)
            {
                return NotFound();

            }
            _context.Historial.Remove(historial);
            _context.SaveChanges();

            TempData["mensaje"] = "El Historial se ha eliminado correctamente";
            return RedirectToAction("Index");
        }

    }
}
