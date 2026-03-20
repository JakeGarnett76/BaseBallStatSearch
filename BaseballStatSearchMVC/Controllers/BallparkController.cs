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
    public class BallparkController : Controller
    {
        private readonly RetroContext _context;

        public BallparkController(RetroContext context)
        {
            _context = context;
        }

        // GET: Ballpark
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ballparks.ToListAsync());
        }

        // GET: Ballpark/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballpark = await _context.Ballparks
                .FirstOrDefaultAsync(m => m.ParkId == id);
            if (ballpark == null)
            {
                return NotFound();
            }

            return View(ballpark);
        }

        // GET: Ballpark/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ballpark/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParkId,Name,Aka,City,State,Start,End,League,Notes")] Ballpark ballpark)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ballpark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ballpark);
        }

        // GET: Ballpark/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballpark = await _context.Ballparks.FindAsync(id);
            if (ballpark == null)
            {
                return NotFound();
            }
            return View(ballpark);
        }

        // POST: Ballpark/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ParkId,Name,Aka,City,State,Start,End,League,Notes")] Ballpark ballpark)
        {
            if (id != ballpark.ParkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ballpark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BallparkExists(ballpark.ParkId))
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
            return View(ballpark);
        }

        // GET: Ballpark/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballpark = await _context.Ballparks
                .FirstOrDefaultAsync(m => m.ParkId == id);
            if (ballpark == null)
            {
                return NotFound();
            }

            return View(ballpark);
        }

        // POST: Ballpark/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ballpark = await _context.Ballparks.FindAsync(id);
            if (ballpark != null)
            {
                _context.Ballparks.Remove(ballpark);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BallparkExists(string id)
        {
            return _context.Ballparks.Any(e => e.ParkId == id);
        }
    }
}
