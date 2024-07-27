using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcVhsLibrary.Data;
using MvcVhsLibrary.Helpers;
using MvcVhsLibrary.Models;

namespace MvcVhsLibrary.Controllers
{
    [Authorize] // Locks the specific page behind user logon
    public class VHSTapesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VHSTapesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VHSTapes
        // GET: VHSTapes?page=1
        // GET: VHSTapes?page=2&pageSize=20
        public async Task<IActionResult> Index(int? page, int pageSize = 10)
        {
            // Get the full list of items (assuming it's IQueryable or IEnumerable)
            var allItems = await _context.VHSTape.ToListAsync(); // Replace with your actual data retrieval

            // Paginate the items
            var paginatedItems = PaginatedList<VHSTape>.Create(allItems.AsQueryable(), page ?? 1, pageSize);

            return View(paginatedItems);
        }

        public string MyTapeLibrary()
        {
            return "My tapes";
        }

        // GET: VHSTapes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHSTape = await _context.VHSTape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vHSTape == null)
            {
                return NotFound();
            }

            return View(vHSTape);
        }

        // GET: VHSTapes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VHSTapes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovieName,ReleaseDate,Genre,Barcode,TotalTime,Company,Country")] VHSTape vHSTape)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vHSTape);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vHSTape);
        }

        // GET: VHSTapes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHSTape = await _context.VHSTape.FindAsync(id);
            if (vHSTape == null)
            {
                return NotFound();
            }
            return View(vHSTape);
        }

        // POST: VHSTapes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieName,ReleaseDate,Genre,Barcode,TotalTime,Company,Country")] VHSTape vHSTape)
        {
            if (id != vHSTape.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vHSTape);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VHSTapeExists(vHSTape.Id))
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
            return View(vHSTape);
        }

        // GET: VHSTapes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHSTape = await _context.VHSTape
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vHSTape == null)
            {
                return NotFound();
            }

            return View(vHSTape);
        }

        // POST: VHSTapes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vHSTape = await _context.VHSTape.FindAsync(id);
            if (vHSTape != null)
            {
                _context.VHSTape.Remove(vHSTape);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VHSTapeExists(int id)
        {
            return _context.VHSTape.Any(e => e.Id == id);
        }
    }
}
