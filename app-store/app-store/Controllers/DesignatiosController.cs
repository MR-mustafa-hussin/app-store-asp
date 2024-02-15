using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_store.Data;
using app_store.Models;

namespace app_store.Controllers
{
    public class DesignatiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DesignatiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Designatios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Designatios.ToListAsync());
        }

        // GET: Designatios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designatio = await _context.Designatios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designatio == null)
            {
                return NotFound();
            }

            return View(designatio);
        }

        // GET: Designatios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designatios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,CreatedId,CreatedOn,ModifiedById,ModifiedByOn")] Designatio designatio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(designatio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(designatio);
        }

        // GET: Designatios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designatio = await _context.Designatios.FindAsync(id);
            if (designatio == null)
            {
                return NotFound();
            }
            return View(designatio);
        }

        // POST: Designatios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name,CreatedId,CreatedOn,ModifiedById,ModifiedByOn")] Designatio designatio)
        {
            if (id != designatio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(designatio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesignatioExists(designatio.Id))
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
            return View(designatio);
        }

        // GET: Designatios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var designatio = await _context.Designatios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designatio == null)
            {
                return NotFound();
            }

            return View(designatio);
        }

        // POST: Designatios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var designatio = await _context.Designatios.FindAsync(id);
            if (designatio != null)
            {
                _context.Designatios.Remove(designatio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesignatioExists(int id)
        {
            return _context.Designatios.Any(e => e.Id == id);
        }
    }
}
