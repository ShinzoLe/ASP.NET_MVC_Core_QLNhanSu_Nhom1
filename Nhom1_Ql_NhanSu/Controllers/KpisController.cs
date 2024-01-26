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
    public class KpisController : Controller
    {
        private readonly QL_NhanSuContext _context;

        public KpisController(QL_NhanSuContext context)
        {
            _context = context;
        }

        // GET: Kpis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kpi1s.ToListAsync());
        }

        // GET: Kpis/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kpi = await _context.Kpi1s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpi == null)
            {
                return NotFound();
            }

            return View(kpi);
        }

       //// GET: Kpis/Create
       // public IActionResult Create()
       // {
       //     return View();
       // }

       // // POST: Kpis/Create
       // // To protect from overposting attacks, enable the specific properties you want to bind to.
       // // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

       // //[HttpPost]
       // // [ValidateAntiForgeryToken]
       // public async Task<IActionResult> Create([Bind("Id,HoTen,ChucVu,DiLamDungGio,DiLamDayDu,HoanThanhTotCongViec,DanhGiaKpi")] Kpi kpi)
       // {
       //     if (ModelState.IsValid)
       //     {
       //         _context.Add(kpi);
       //         await _context.SaveChangesAsync();
       //         return RedirectToAction(nameof(Index));
       //     }
       //     return View(kpi);
       // }

        // GET: Kpis/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kpi = await _context.Kpi1s.FindAsync(id);
            if (kpi == null)
            {
                return NotFound();
            }
            return View(kpi);
        }

        // POST: Kpis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,HoTen,ChucVu,DiLamDungGio,DiLamDayDu,HoanThanhTotCongViec,DanhGiaKpi")] Kpi1 kpi)
        {
            if (id != kpi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpiExists(kpi.Id))
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
            return View(kpi);
        }

        //// GET: Kpis/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var kpi = await _context.Kpis
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (kpi == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(kpi);
        //}

        //// POST: Kpis/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var kpi = await _context.Kpis.FindAsync(id);
        //    _context.Kpis.Remove(kpi);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool KpiExists(string id)
        {
            return _context.Kpi1s.Any(e => e.Id == id);
        }
    }
}
