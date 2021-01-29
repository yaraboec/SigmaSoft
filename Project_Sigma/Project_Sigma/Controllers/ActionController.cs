using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Controllers
{
    public class ActionController : Controller
    {
        private readonly ProjectSigmaContext _context;

        public ActionController(ProjectSigmaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actions.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Models.Action action = await _context.Actions.FirstOrDefaultAsync(p => p.IdAction == id);
                if (action != null)
                    return View(action);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Action vm)
        {

            _context.Actions.Add(vm);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Models.Action action = await _context.Actions.FirstOrDefaultAsync(p => p.IdAction == id);
                if (action != null)
                    return View(action);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Models.Action action = await _context.Actions.FirstOrDefaultAsync(p => p.IdAction == id);
                if (action != null)
                {
                    _context.Actions.Remove(action);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
