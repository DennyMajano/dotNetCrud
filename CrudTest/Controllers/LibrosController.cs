using CrudTest.Data;
using CrudTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTest.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public LibrosController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> librosList = dbContext.Libro;
            return View(librosList);
        }

        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid) {
                dbContext.Libro.Add(libro);
                dbContext.SaveChanges();
                TempData["Message"] = "El libro fue guardado";
                return RedirectToAction("Index");
            }
            return View();
        }

        
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) {
                return NotFound();
             }
            Libro libro = dbContext.Libro.Find(id);
            if (libro == null) {
                return NotFound();
            }
            return View(libro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro) {

            if (ModelState.IsValid) {
                dbContext.Libro.Update(libro);
                dbContext.SaveChanges();
                TempData["Message"] = "El libro fue actualizado";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Libro libro = dbContext.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? id)
        {
            Libro libro = dbContext.Libro.Find(id);
            if (libro==null)
            {
                return NotFound();
            }
            dbContext.Libro.Remove(libro);
            dbContext.SaveChanges();
            TempData["Message"] = "El libro fue eliminado";
            return RedirectToAction("Index");
        }

    }
}
