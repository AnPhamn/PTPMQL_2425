    using DEMOMVC.Models;
    using DEMOMVC.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

namespace Name.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
               return View(await _context.Employee.ToListAsync());
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee.FirstOrDefaultAsync(x => x.CCCDID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("CCCDID, hoVaten, queQuan")] Employee employee)
        {
            
            if (!ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof (Index));
            }
            return View(employee);
         }

         public async Task<IActionResult> Edit(string id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee.FindAsync(id);
            if(employee == null)
            {
                _context.Employee.Remove(employee); 
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
         
         private bool EmployeeExists(string id)
         {
            return _context.Employee.Any(e => e.CCCDID == id);
         }

     }
  }