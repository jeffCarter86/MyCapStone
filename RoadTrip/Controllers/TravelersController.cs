using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoadTrip.Data;
using RoadTrip.Models;
using System.Collections;


namespace RoadTrip.Controllers
{
    public class TravelersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TravelersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Travelers
        public async Task<IActionResult> Index()

        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var traveler = _context.Profiles.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            

            if (traveler == null)

            {

                return View(await _context.Travelers.ToListAsync());

            }
            else
            {
                return View(await _context.Travelers.ToListAsync());
            }
           
        }

            // GET: Travelers/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traveler = await _context.Travelers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traveler == null)
            {
                return NotFound();
            }

            return View(traveler);
        }

        // GET: Travelers/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Sleep()
        {
            return View();
        }
        public IActionResult Eat()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Route()
        {
            return View();
        }

        

        // POST: Travelers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,From,To,Distance,Stops,GasCost,SnackCost,Emergency,TripCost,MonthBudget,BudgetMonth")] Traveler traveler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(traveler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(traveler);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile([Bind("Id,Name,ZipCode")] Profile profile)
        {
            if (ModelState.IsValid)
            { 
                _context.Add(profile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        public ActionResult Compare()

        {

            var trips = _context.Travelers.Select(t => t).ToList();

            var tripN = trips.Select(i => i.Name).Distinct();

            var cost = trips.Select(c => c.TripCost);

            var miles = trips.Select(d => d.Distance);

            ViewBag.TripN = tripN;

            ViewBag.Miles = miles;

            ViewBag.Cost = cost;

            return View();

        }

        public ActionResult Miles()

        {

            var trips = _context.Travelers.Select(t => t).ToList();

            var tripN = trips.Select(i => i.Name).Distinct();

            var cost = trips.Select(c => c.TripCost);

            var miles = trips.Select(d => d.Distance);

            ViewBag.TripN = tripN;

            ViewBag.Miles = miles;

            ViewBag.Cost = cost;

            return View();

        }

        // GET: Travelers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traveler = await _context.Travelers.FindAsync(id);
            if (traveler == null)
            {
                return NotFound();
            }
            return View(traveler);
        }

        // POST: Travelers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,From,To,Distance,Stops,GasCost,SnackCost,Emergency,TripCost,MonthBudget,BudgetMonth")] Traveler traveler)
        {
            if (id != traveler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(traveler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelerExists(traveler.Id))
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
            return View(traveler);
        }

        // GET: Travelers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traveler = await _context.Travelers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traveler == null)
            {
                return NotFound();
            }

            return View(traveler);
        }

        // POST: Travelers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var traveler = await _context.Travelers.FindAsync(id);
            _context.Travelers.Remove(traveler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelerExists(int id)
        {
            return _context.Travelers.Any(e => e.Id == id);
        }
    }
}
