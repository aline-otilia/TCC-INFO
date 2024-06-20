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
     public class DepoimentosController : Controller
   {
        private readonly AppDbContext _context;

        public DepoimentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Depoimento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Depoimentos.ToListAsync());
        }

        // GET: Depoimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depoimento = await _context.Depoimentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (depoimento == null)
            {
                return NotFound();
            }

            return View(depoimento);
        }

        // GET: Depoimento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Depoimento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Autor,Conteudo,DataDepoimento,Aprovado")] Depoimento depoimento)
        {
            if (ModelState.IsValid)
            {
                depoimento.DataDepoimento = DateTime.Now;
                _context.Add(depoimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(depoimento);
        }

        // GET: Depoimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depoimento = await _context.Depoimentos.FindAsync(id);
            if (depoimento == null)
            {
                return NotFound();
            }
            return View(depoimento);
        }

        // POST: Depoimento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Autor,Conteudo,DataDepoimento,Aprovado")] Depoimento depoimento)
        {
            if (id != depoimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(depoimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepoimentoExists(depoimento.Id))
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
            return View(depoimento);
        }

        // GET: Depoimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depoimento = await _context.Depoimentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (depoimento == null)
            {
                return NotFound();
            }

            return View(depoimento);
        }

        // POST: Depoimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var depoimento = await _context.Depoimentos.FindAsync(id);
            _context.Depoimentos.Remove(depoimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepoimentoExists(int id)
        {
            return _context.Depoimentos.Any(e => e.Id == id);
        }
    }
}
