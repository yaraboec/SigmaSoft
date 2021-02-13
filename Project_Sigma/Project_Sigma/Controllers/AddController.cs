using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_Sigma.Data;
using Project_Sigma.Models;
using Project_Sigma.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace Project_Sigma.Controllers
{
    public class AddController : Controller
    {
        private readonly ProjectSigmaContext _context;

        string img;

        private readonly IWebHostEnvironment _webEnv;
        public AddController(ProjectSigmaContext context,IWebHostEnvironment webEnv)
        {
            _context = context;
            _webEnv = webEnv;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizzas.ToListAsync());
        }
        public ActionResult AddingIngr()
        {
            dynamic model = new ExpandoObject();
            PizzaActions pizza = new PizzaActions(_context);
            IngredActions ingred = new IngredActions(_context);
            PizContAction cont = new PizContAction(_context);
            model.Pizzas = pizza.GetAllPizza();
            model.Ingred = ingred.GetAllIngred();
            model.All = cont.GetAll();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditIngr(int? id, int? id1)
        {
            if (id != null && id1 != null)
            {
                PizzaContainIngr pizza = await _context.PizzaContainIngrs.FirstOrDefaultAsync(p => p.IdPizza == id && p.IdIngredient == id1);
                if (pizza != null)
                    return View(pizza);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditIngr(PizzaContainIngr pizza)
        {
            _context.PizzaContainIngrs.Update(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction("AddingIngr");
        }
        public IActionResult Adding(int id = 0)
        {
            PizzaContIngr stockMod = new PizzaContIngr();
            stockMod.Ingredient = _context.Ingredients.ToList();
            stockMod.Pizza = _context.Pizzas.ToList();
           
            return View(stockMod);
        }
        public async Task<IActionResult> DeleteIngr(int? id, int? id1)
        {
            if (id != null && id1 != null)
            {
                PizzaContainIngr pizza = await _context.PizzaContainIngrs.FirstOrDefaultAsync(p => p.IdPizza == id && p.IdIngredient == id1);
                if (pizza != null)
                {
                    _context.PizzaContainIngrs.Remove(pizza);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("AddingIngr");
                }
            }
            return NotFound();

        }
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Pizza pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.IdPizza == id);
                if (pizza != null)
                    return View(pizza);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Pizza pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.IdPizza == id);
                if (pizza != null)
                {
                    _context.Pizzas.Remove(pizza);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Create(PizzaViewModel vm)
        {

            string stringFileName = UploadedFile(vm);

            img = stringFileName;

            var pizza = new Pizza
            {
                Img = stringFileName,
                Name = vm.Name,
                Weight = 0,
                PriceWork = vm.PriceWork,
                ResultPrice = 0,
                Sostav = ""

            };
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Adding(PizzaContainIngr ingrcont)
        {
            _context.PizzaContainIngrs.Add(ingrcont);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Pizza piz = await _context.Pizzas.FirstOrDefaultAsync(p => p.IdPizza == id);
                PizzeEditViewModel pizEdit = new PizzeEditViewModel
                {
                    IdPizza = piz.IdPizza,
                    Name = piz.Name,
                    PriceWork = piz.PriceWork,
                    ExistImg = piz.Img
                };
                return View(pizEdit);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PizzeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Pizza pizza = _context.Pizzas.Where(c => c.IdPizza == model.IdPizza).FirstOrDefault();
                pizza.Name = model.Name;
                pizza.PriceWork = model.PriceWork;
                if (model.Img != null)
                {

                    if (model.ExistImg != null)
                    {
                        string filePath = Path.Combine(_webEnv.WebRootPath,
                            "Img", model.ExistImg);
                        System.IO.File.Delete(filePath);
                    }
                    pizza.Img = UploadedFile(model);
                }
                _context.Pizzas.Update(pizza);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }

            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Pizza pizza = await _context.Pizzas.FirstOrDefaultAsync(p => p.IdPizza == id);
                if (pizza != null)
                    return View(pizza);
            }
            return NotFound();
        }

        private string UploadedFile(PizzaViewModel model)
        {
            string uniqueFileName = null;

            if (model.Img != null)
            {
                string uploadsFolder = Path.Combine(_webEnv.WebRootPath,"Img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Img.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
