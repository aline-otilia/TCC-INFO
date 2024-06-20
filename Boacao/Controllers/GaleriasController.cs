using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Boacao.Data;
using Boacao.Models;

namespace Boacao.Controllers
{
    public class GaleriasController : Controller
   {
        private readonly AppDbContext _context;

        public GaleriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Galeria
        public async Task<IActionResult> Index()
        {
            return View(await _context.Galerias.ToListAsync());
        }

        // GET: Galeria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // GET: Galeria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galeria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,Imagem,DataUpload,Ativo")] Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                galeria.DataUpload = DateTime.Now; // Set DataUpload to the current date
                _context.Add(galeria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galeria);
        }

        // GET: Galeria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias.FindAsync(id);
            if (galeria == null)
            {
                return NotFound();
            }
            return View(galeria);
        }

        // POST: Galeria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,Imagem,DataUpload,Ativo")] Galeria galeria)
        {
            if (id != galeria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galeria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleriaExists(galeria.Id))
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
            return View(galeria);
        }

        // GET: Galeria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // POST: Galeria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galeria = await _context.Galerias.FindAsync(id);
            if (galeria != null)
            {
                _context.Galerias.Remove(galeria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleriaExists(int id)
        {
            return _context.Galerias.Any(e => e.Id == id);
        }
    }
}