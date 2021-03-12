using JugueteriApp.Data;
using JugueteriApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JugueteriApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiJugueteriaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ApiJugueteriaController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/<ApiJugueteriaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ListaProductos = await _db.Productos.ToListAsync();
            return Ok(ListaProductos);
        }

        // GET api/<ApiJugueteriaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiJugueteriaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            _db.Add(producto);
            await _db.SaveChangesAsync();
            return Ok(producto);
        }

        // PUT api/<ApiJugueteriaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            _db.Update(producto);
            await _db.SaveChangesAsync();
            return Ok(new { message = "La targeta se actualizo con exito" });
        }

        // DELETE api/<ApiJugueteriaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _db.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            _db.Productos.Remove(producto);
            await _db.SaveChangesAsync();
            return Ok(new { message = "La tarjeta fue eliminada con exito!" });
        }
    }
}
