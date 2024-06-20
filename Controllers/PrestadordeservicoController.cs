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
    public class PrestadordeservicoController : Controller
    {
        private readonly Contexto _context;

        public PrestadordeservicoController(Contexto context)
        {
            _context = context;
        }

        // GET: Prestadordeservico
        public async Task<IActionResult> Index()
        {
              return _context.Prestadordeservico != null ? 
                          View(await _context.Prestadordeservico.ToListAsync()) :
                          Problem("Entity set 'Contexto.Prestadordeservico'  is null.");
        }

        // GET: Prestadordeservico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prestadordeservico == null)
            {
                return NotFound();
            }

            var prestadordeservico = await _context.Prestadordeservico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestadordeservico == null)
            {
                return NotFound();
            }

            return View(prestadordeservico);
        }

        // GET: Prestadordeservico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prestadordeservico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomePrestador,TipoServico,Descricao,Endereco,Numero,Email")] Prestadordeservico prestadordeservico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestadordeservico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prestadordeservico);
        }

        // GET: Prestadordeservico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prestadordeservico == null)
            {
                return NotFound();
            }

            var prestadordeservico = await _context.Prestadordeservico.FindAsync(id);
            if (prestadordeservico == null)
            {
                return NotFound();
            }
            return View(prestadordeservico);
        }

        // POST: Prestadordeservico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomePrestador,TipoServico,Descricao,Endereco,Numero,Email")] Prestadordeservico prestadordeservico)
        {
            if (id != prestadordeservico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestadordeservico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestadordeservicoExists(prestadordeservico.Id))
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
            return View(prestadordeservico);
        }

        // GET: Prestadordeservico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prestadordeservico == null)
            {
                return NotFound();
            }

            var prestadordeservico = await _context.Prestadordeservico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestadordeservico == null)
            {
                return NotFound();
            }

            return View(prestadordeservico);
        }

        // POST: Prestadordeservico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prestadordeservico == null)
            {
                return Problem("Entity set 'Contexto.Prestadordeservico'  is null.");
            }
            var prestadordeservico = await _context.Prestadordeservico.FindAsync(id);
            if (prestadordeservico != null)
            {
                _context.Prestadordeservico.Remove(prestadordeservico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestadordeservicoExists(int id)
        {
          return (_context.Prestadordeservico?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
