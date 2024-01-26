using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nhom1_Ql_NhanSu.Models.Entities;

namespace Nhom1_Ql_NhanSu.Controllers
{
    public class DchinhsachesController : Controller
    {
        private readonly QL_NhanSuContext _context;

        public DchinhsachesController(QL_NhanSuContext context)
        {
            _context = context;
        }

        // GET: Dchinhsaches
        public async Task<IActionResult> Index()
        {
            return View("Index", await _context.Dchinhsaches.ToListAsync());
        }

        // GET: Dchinhsaches/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dchinhsach = await _context.Dchinhsaches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dchinhsach == null)
            {
                return NotFound();
            }

            return View(dchinhsach);
        }

        // GET: Dchinhsaches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dchinhsaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Text,Class")] Dchinhsach dchinhsach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dchinhsach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dchinhsach);
        }

        // GET: Dchinhsaches/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dchinhsach = await _context.Dchinhsaches.FindAsync(id);
            if (dchinhsach == null)
            {
                return NotFound();
            }
            return View(dchinhsach);
        }

        // POST: Dchinhsaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Text,Class")] Dchinhsach dchinhsach)
        {
            if (id != dchinhsach.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dchinhsach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DchinhsachExists(dchinhsach.Id))
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
            return View(dchinhsach);
        }

        // GET: Dchinhsaches/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dchinhsach = await _context.Dchinhsaches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dchinhsach == null)
            {
                return NotFound();
            }

            return View(dchinhsach);
        }

        // POST: Dchinhsaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dchinhsach = await _context.Dchinhsaches.FindAsync(id);
            _context.Dchinhsaches.Remove(dchinhsach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DchinhsachExists(string id)
        {
            return _context.Dchinhsaches.Any(e => e.Id == id);
        }
    }
}
