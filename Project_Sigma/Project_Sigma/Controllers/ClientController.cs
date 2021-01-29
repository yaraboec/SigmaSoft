using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Sigma.Data;
using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Controllers
{
    public class ClientController : Controller
    {
        private readonly ProjectSigmaContext _context;

        public ClientController(ProjectSigmaContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {

            return View(await _context.Clients.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            dynamic model = new ExpandoObject();
            if (id != null)
            {
               Client user = await _context.Clients.FirstOrDefaultAsync(p => p.IdClient == id);
               Order ord = await _context.Orders.FirstOrDefaultAsync(p => p.IdClient == id);
                model.Client = user;
                model.Order = ord;
                if (user != null)
                    return View(model);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Client user = await _context.Clients.FirstOrDefaultAsync(p => p.IdClient == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Client user)
        {
            _context.Clients.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
       public async Task <IActionResult> Create(Client vm)
       {

            _context.Clients.Add(vm);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
       }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Client user = await _context.Clients.FirstOrDefaultAsync(p => p.IdClient == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Client user = await _context.Clients.FirstOrDefaultAsync(p => p.IdClient == id);
                if (user != null)
                {
                    _context.Clients.Remove(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
