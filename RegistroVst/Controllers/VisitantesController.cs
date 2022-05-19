using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroVst.Data;
using RegistroVst.Models;

namespace RegistroVst.Controllers
{
    public class VisitantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisitantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Visitante> listVisitantes = _context.Visitante;
            return View(listVisitantes);
        }

        //Http Get Create
        public IActionResult Create()
        {           
            return View();
        }
        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                _context.Visitante.Add(visitante);
                _context.SaveChanges();

                TempData["mensaje"] = "El Visitante se ha registrado correctamente";
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
            // Obtener el Visitante
            var Visitante = _context.Visitante.Find(id);
            if (Visitante == null)
            {
                return NotFound();
            }
            return View(Visitante);
        }
        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                _context.Visitante.Update(visitante);
                _context.SaveChanges();

                TempData["mensaje"] = "El Visitante se ha actualizado correctamente";
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
            // Obtener el libro
            var Visitante = _context.Visitante.Find(id);
            if (Visitante == null)
            {
                return NotFound();
            }
            return View(Visitante);
        }
        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVisitante(int? id)
        {
            // Obtener el Visitante por id
            var visitan = _context.Visitante.Find(id);
            if (visitan == null)
            {
                return NotFound();

            }
            _context.Visitante.Remove(visitan);
            _context.SaveChanges();

            TempData["mensaje"] = "El visitante se ha eliminado correctamente";
            return RedirectToAction("Index");
        }

    }
}
