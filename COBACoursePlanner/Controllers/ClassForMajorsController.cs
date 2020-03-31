using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COBACoursePlanner.Data;
using COBACoursePlanner.Models;

namespace COBACoursePlanner.Controllers
{
    public class ClassForMajorsController : Controller
    {
        private readonly MvcClassForMajorContext _context;

        public ClassForMajorsController(MvcClassForMajorContext context)
        {
            _context = context;
        }

        // GET: ClassForMajors
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassForMajor.ToListAsync());
        }

        // GET: ClassForMajors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classForMajor = await _context.ClassForMajor
                .FirstOrDefaultAsync(m => m.MajorClassID == id);
            if (classForMajor == null)
            {
                return NotFound();
            }

            return View(classForMajor);
        }

        // GET: ClassForMajors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassForMajors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MajorClassID,MajorID,ClassID")] ClassForMajor classForMajor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classForMajor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classForMajor);
        }

        // GET: ClassForMajors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classForMajor = await _context.ClassForMajor.FindAsync(id);
            if (classForMajor == null)
            {
                return NotFound();
            }
            return View(classForMajor);
        }

        // POST: ClassForMajors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MajorClassID,MajorID,ClassID")] ClassForMajor classForMajor)
        {
            if (id != classForMajor.MajorClassID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classForMajor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassForMajorExists(classForMajor.MajorClassID))
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
            return View(classForMajor);
        }

        // GET: ClassForMajors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classForMajor = await _context.ClassForMajor
                .FirstOrDefaultAsync(m => m.MajorClassID == id);
            if (classForMajor == null)
            {
                return NotFound();
            }

            return View(classForMajor);
        }

        // POST: ClassForMajors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classForMajor = await _context.ClassForMajor.FindAsync(id);
            _context.ClassForMajor.Remove(classForMajor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassForMajorExists(int id)
        {
            return _context.ClassForMajor.Any(e => e.MajorClassID == id);
        }
    }
}
