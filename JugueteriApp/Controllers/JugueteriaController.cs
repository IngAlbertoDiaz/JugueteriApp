using JugueteriApp.Data;
using JugueteriApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JugueteriApp.Controllers
{
    public class JugueteriaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public JugueteriaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Producto> objProductos = _db.Productos;
            return View(objProductos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto Obj)
        {
            _db.Productos.Add(Obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Productos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Producto Obj)
        {
            _db.Productos.Update(Obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Productos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProducto(int? id)
        {
            var obj = _db.Productos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Productos.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
