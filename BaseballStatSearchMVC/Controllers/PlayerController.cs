using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseballStatSearchMVC.Models;

namespace BaseballStatSearchMVC.Controllers
{
    public class PlayerController : Controller
    {
        private readonly RetroContext _context;

        public PlayerController(RetroContext context)
        {
            _context = context;
        }

        // GET: Player
        public async Task<IActionResult> Index()
        {
            return View(await _context.Biofile2025s.ToListAsync());
        }

        // GET: Player/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biofile2025 = await _context.Biofile2025s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biofile2025 == null)
            {
                return NotFound();
            }

            return View(biofile2025);
        }

        // GET: Player/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastName,UseName,FullName,BirthDate,BirthCity,BirthState,BirthCountry,DeathDate,DeathCity,DeathState,DeathCountry,Cemetery,CemeteryCity,CemeteryState,CemeteryCtry,CemeteryNote,BirthName,AltName,DebutPlay,LastPlay,DebutCoach,LastCoach,DebutManager,LastManager,DebutUmp,LastUmp,Bats,Throws,Height,Weight,Hof")] Biofile2025 biofile2025)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biofile2025);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biofile2025);
        }

        // GET: Player/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biofile2025 = await _context.Biofile2025s.FindAsync(id);
            if (biofile2025 == null)
            {
                return NotFound();
            }
            return View(biofile2025);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,LastName,UseName,FullName,BirthDate,BirthCity,BirthState,BirthCountry,DeathDate,DeathCity,DeathState,DeathCountry,Cemetery,CemeteryCity,CemeteryState,CemeteryCtry,CemeteryNote,BirthName,AltName,DebutPlay,LastPlay,DebutCoach,LastCoach,DebutManager,LastManager,DebutUmp,LastUmp,Bats,Throws,Height,Weight,Hof")] Biofile2025 biofile2025)
        {
            if (id != biofile2025.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biofile2025);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Biofile2025Exists(biofile2025.Id))
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
            return View(biofile2025);
        }

        // GET: Player/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biofile2025 = await _context.Biofile2025s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biofile2025 == null)
            {
                return NotFound();
            }

            return View(biofile2025);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var biofile2025 = await _context.Biofile2025s.FindAsync(id);
            if (biofile2025 != null)
            {
                _context.Biofile2025s.Remove(biofile2025);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Biofile2025Exists(string id)
        {
            return _context.Biofile2025s.Any(e => e.Id == id);
        }
    }
}
