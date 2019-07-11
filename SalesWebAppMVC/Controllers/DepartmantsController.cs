﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebAppMVC.Models;

namespace SalesWebAppMVC.Controllers
{
    public class DepartmantsController : Controller
    {
        private readonly SalesWebAppMVCContext _context;

        public DepartmantsController(SalesWebAppMVCContext context)
        {
            _context = context;
        }

        // GET: Departmants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departmant.ToListAsync());
        }

        // GET: Departmants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmant = await _context.Departmant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departmant == null)
            {
                return NotFound();
            }

            return View(departmant);
        }

        // GET: Departmants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departmants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Departmant departmant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departmant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmant);
        }

        // GET: Departmants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmant = await _context.Departmant.FindAsync(id);
            if (departmant == null)
            {
                return NotFound();
            }
            return View(departmant);
        }

        // POST: Departmants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Departmant departmant)
        {
            if (id != departmant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departmant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmantExists(departmant.Id))
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
            return View(departmant);
        }

        // GET: Departmants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmant = await _context.Departmant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departmant == null)
            {
                return NotFound();
            }

            return View(departmant);
        }

        // POST: Departmants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departmant = await _context.Departmant.FindAsync(id);
            _context.Departmant.Remove(departmant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmantExists(int id)
        {
            return _context.Departmant.Any(e => e.Id == id);
        }
    }
}
