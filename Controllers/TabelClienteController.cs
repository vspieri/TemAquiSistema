using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tem_Aqui.Models;

namespace Tem_Aqui.Controllers
{
    public class TabelClienteController : Controller
    {
        private readonly Contexto _context;

        public TabelClienteController(Contexto context)
        {
            _context = context;
        }

        // GET: TabelCliente
        public async Task<IActionResult> Index()
        {
              return _context.TabelClientes != null ? 
                          View(await _context.TabelClientes.ToListAsync()) :
                          Problem("Entity set 'Contexto.TabelClientes'  is null.");
        }

        // GET: TabelCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TabelClientes == null)
            {
                return NotFound();
            }

            var tabelClientes = await _context.TabelClientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelClientes == null)
            {
                return NotFound();
            }

            return View(tabelClientes);
        }

        // GET: TabelCliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TabelCliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteNome,EndereçoId,EmailId,NumeroId")] TabelClientes tabelClientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabelClientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabelClientes);
        }

        // GET: TabelCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TabelClientes == null)
            {
                return NotFound();
            }

            var tabelClientes = await _context.TabelClientes.FindAsync(id);
            if (tabelClientes == null)
            {
                return NotFound();
            }
            return View(tabelClientes);
        }

        // POST: TabelCliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteNome,EndereçoId,EmailId,NumeroId")] TabelClientes tabelClientes)
        {
            if (id != tabelClientes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabelClientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelClientesExists(tabelClientes.Id))
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
            return View(tabelClientes);
        }

        // GET: TabelCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TabelClientes == null)
            {
                return NotFound();
            }

            var tabelClientes = await _context.TabelClientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelClientes == null)
            {
                return NotFound();
            }

            return View(tabelClientes);
        }

        // POST: TabelCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TabelClientes == null)
            {
                return Problem("Entity set 'Contexto.TabelClientes'  is null.");
            }
            var tabelClientes = await _context.TabelClientes.FindAsync(id);
            if (tabelClientes != null)
            {
                _context.TabelClientes.Remove(tabelClientes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelClientesExists(int id)
        {
          return (_context.TabelClientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
