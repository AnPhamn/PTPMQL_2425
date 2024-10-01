using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DEMOMVC.Data;
using DEMOMVC.Models;
namespace DEMOMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context){
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }
        
       public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FirstOrDefaultAsync(m=>m.CCCDID == id);

            if (person == null)
            {
                return NotFound();

            }
            return View(person);
        }

        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create ([Bind ("CCCDID, hoVaten, queQuan")] Person person)
        {
            if(ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof (Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Edit (string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            if (person == null)
                {
                    return NotFound();
                }
                return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind("HovaTen, CCCDID, Address")]Person person)
        {
            if (id != person.CCCDID)
            {
                return NotFound();
            }
             if (ModelState.IsValid)
             {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.CCCDID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof (Index));
             }
             return View(person);
        }

        public async Task<IActionResult> Delete (string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FirstOrDefaultAsync(m=>m.CCCDID == id);
            if (person != null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (string id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person != null)
            {
                _context.Person.Remove(person);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PersonExists(string id)
        {
            return _context.Person.Any(e=>e.CCCDID == id);
        }
    }
}