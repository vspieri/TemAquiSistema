using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TemAqui.Models;
using Tem_Aqui.Models;

namespace Tem_Aqui.Controllers
{
    public class SerPresController : Controller
    {
        private readonly Contexto _context;

        public SerPresController(Contexto context)
        {
            _context = context;
        }

        // GET: SerPres
        public async Task<IActionResult> Index()
        {
            var contexto = _context.SerPres.Include(s => s.Prestadordeservico);
            return View(await contexto.ToListAsync());
        }

        // GET: SerPres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SerPres == null)
            {
                return NotFound();
            }

            var serPres = await _context.SerPres
                .Include(s => s.Prestadordeservico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serPres == null)
            {
                return NotFound();
            }

            return View(serPres);
        }

        // GET: SerPres/Create
        public IActionResult Create()
        {
            ViewData["PrestadordeservicoId"] = new SelectList(_context.Prestadordeservico, "Id", "Id");
            return View();
        }

        // POST: SerPres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrestadordeservicoId,DataEHR,Preco")] SerPres serPres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serPres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PrestadordeservicoId"] = new SelectList(_context.Prestadordeservico, "Id", "Id", serPres.PrestadordeservicoId);
            return View(serPres);
        }

        // GET: SerPres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SerPres == null)
            {
                return NotFound();
            }

            var serPres = await _context.SerPres.FindAsync(id);
            if (serPres == null)
            {
                return NotFound();
            }
            ViewData["PrestadordeservicoId"] = new SelectList(_context.Prestadordeservico, "Id", "Id", serPres.PrestadordeservicoId);
            return View(serPres);
        }

        // POST: SerPres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrestadordeservicoId,DataEHR,Preco")] SerPres serPres)
        {
            if (id != serPres.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serPres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SerPresExists(serPres.Id))
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
            ViewData["PrestadordeservicoId"] = new SelectList(_context.Prestadordeservico, "Id", "Id", serPres.PrestadordeservicoId);
            return View(serPres);
        }

        // GET: SerPres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SerPres == null)
            {
                return NotFound();
            }

            var serPres = await _context.SerPres
                .Include(s => s.Prestadordeservico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serPres == null)
            {
                return NotFound();
            }

            return View(serPres);
        }

        // POST: SerPres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SerPres == null)
            {
                return Problem("Entity set 'Contexto.SerPres'  is null.");
            }
            var serPres = await _context.SerPres.FindAsync(id);
            if (serPres != null)
            {
                _context.SerPres.Remove(serPres);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SerPresExists(int id)
        {
          return (_context.SerPres?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
