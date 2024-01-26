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
    public class KhoaDaoTaosController : Controller
    {
        private readonly QL_NhanSuContext _context;

        public KhoaDaoTaosController(QL_NhanSuContext context)
        {
            _context = context;
        }

        // GET: KhoaDaoTaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhoaDaoTaos.ToListAsync());
        }

        // GET: KhoaDaoTaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoaDaoTao = await _context.KhoaDaoTaos
                .FirstOrDefaultAsync(m => m.MaKhoa == id);
            if (khoaDaoTao == null)
            {
                return NotFound();
            }

            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhoaDaoTaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKhoa,TenKhoa,MoTa,ThoiGianBatDau,ThoiGianKetThuc")] KhoaDaoTao khoaDaoTao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoaDaoTao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoaDaoTao = await _context.KhoaDaoTaos.FindAsync(id);
            if (khoaDaoTao == null)
            {
                return NotFound();
            }
            return View(khoaDaoTao);
        }

        // POST: KhoaDaoTaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaKhoa,TenKhoa,MoTa,ThoiGianBatDau,ThoiGianKetThuc")] KhoaDaoTao khoaDaoTao)
        {
            if (id != khoaDaoTao.MaKhoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoaDaoTao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoaDaoTaoExists(khoaDaoTao.MaKhoa))
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
            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoaDaoTao = await _context.KhoaDaoTaos
                .FirstOrDefaultAsync(m => m.MaKhoa == id);
            if (khoaDaoTao == null)
            {
                return NotFound();
            }

            return View(khoaDaoTao);
        }

        // POST: KhoaDaoTaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khoaDaoTao = await _context.KhoaDaoTaos.FindAsync(id);
            _context.KhoaDaoTaos.Remove(khoaDaoTao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoaDaoTaoExists(int id)
        {
            return _context.KhoaDaoTaos.Any(e => e.MaKhoa == id);
        }
    }
}
