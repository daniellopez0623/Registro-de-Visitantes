using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroVst.Data;
using RegistroVst.Models;

namespace RegistroVst.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Evento> listEventos = _context.Evento;
            return View(listEventos);
        }

        //Http Get Create
        public IActionResult Create()
        {           
            return View();
        }
        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Evento.Add(evento);
                _context.SaveChanges();

                TempData["mensaje"] = "El Evento se ha registrado correctamente";
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
            // Obtener el libro
            var Evento = _context.Evento.Find(id);
            if (Evento == null)
            {
                return NotFound();
            }
            return View(Evento);
        }
        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Evento.Update(evento);
                _context.SaveChanges();

                TempData["mensaje"] = "El Evento se ha actualizado correctamente";
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
            // Obtener el Evento
            var Evento = _context.Evento.Find(id);
            if (Evento == null)
            {
                return NotFound();
            }
            return View(Evento);
        }
        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEvento(int? id)
        {
            // Obtener el Evento por id
            var evento = _context.Evento.Find(id);
            if (evento == null)
            {
                return NotFound();

            }
            _context.Evento.Remove(evento);
            _context.SaveChanges();

            TempData["mensaje"] = "El evento se ha eliminado correctamente";
            return RedirectToAction("Index");
        }

    }
}
