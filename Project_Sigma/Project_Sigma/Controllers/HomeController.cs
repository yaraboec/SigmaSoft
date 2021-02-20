using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Sigma.Data;
using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Project_Sigma.Controllers
{
    public class HomeController : Controller
    {
        
        ProjectSigmaContext db;
        public HomeController(ProjectSigmaContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            PizzaActions pizza = new PizzaActions(db);
            if (TempData["Cart"] != null)
            {
                ViewData["Cart"] = JsonConvert.DeserializeObject<List<Cart>>((string)TempData["Cart"]);
                float x = 0;
                List<Cart> carts1 = ViewData["Cart"] as List<Cart>;
                foreach (var item in carts1)
                {
                    x += item.bill;

                }

                TempData["total"] = JsonConvert.SerializeObject(x);
            }
            TempData.Keep();
            return View(db.Pizzas.OrderByDescending(x => x.IdPizza).ToList());
        }
        public IActionResult Addtocard(int? id)
        {
            Pizza pizza = db.Pizzas.Where(x => x.IdPizza == id).SingleOrDefault();
            return View(pizza);
        }
        
        [HttpPost]
        public IActionResult Addtocard(Pizza piz,string qty,int id)
        {
            List<Cart> carts = new List<Cart>();

            Pizza pizza = db.Pizzas.Where(x => x.IdPizza == id).SingleOrDefault();


            Cart cart = new Cart();
            cart.productid = pizza.IdPizza;
            cart.price = (float)pizza.ResultPrice;
            cart.qty = Convert.ToInt32(qty);
            cart.bill = cart.price * cart.qty;
            cart.productname = pizza.Name;
            if (TempData["Cart"] == null)
            {
                carts.Add(cart);
                TempData["Cart"] = JsonConvert.SerializeObject(carts);

            }
            else
            {
                ViewData["Cart"] = JsonConvert.DeserializeObject<List<Cart>>((string)TempData["Cart"]);
                List<Cart> carts1 = ViewData["Cart"] as List<Cart>;
                int flag = 0;
                foreach(var item in carts1)
                {
                    if(item.productid == cart.productid)
                    {
                        item.qty += cart.qty;
                        item.bill += cart.bill;
                        flag = 1;
                    }
                }
                if(flag == 0)
                {
                    carts1.Add(cart);
                }

                TempData["Cart"] = JsonConvert.SerializeObject(carts1);
            }

            TempData.Keep();

            return RedirectToAction("Index");
        }
        public IActionResult checkout()
        {
            if(TempData["Cart"] != null)
            ViewData["Cart"] = JsonConvert.DeserializeObject<List<Cart>>((string)TempData["Cart"]);
            TempData.Keep();
            Cart carta = new Cart();
            return View(carta);
        }
        [HttpPost]
        public IActionResult checkout(Cart abc)
        {

            ViewData["Cart"] = JsonConvert.DeserializeObject<List<Cart>>((string)TempData["Cart"]);
            List<Cart> carts = ViewData["Cart"] as List<Cart>;
            PizContAction piz = new PizContAction(db);

            Order ord = new Order();
            var per = db.Actions.Where(c => c.BeginAction < System.DateTime.Now.TimeOfDay && c.EndAction > System.DateTime.Now.TimeOfDay).ToList();
            double sum = 0;
            ord.IdClient = 2;
            foreach( var ss in carts)
            sum += ss.bill;
            ord.Sum = sum;
            ord.Skidka = 1;
            ord.IdClient = abc.clientid;
            foreach (var dl in per)
            {
                ord.IdAction = dl.IdAction;
                TempData["Action"] = dl.Name;
                TempData["Begin"] = dl.BeginAction.ToString();
                TempData["End"] = dl.EndAction.ToString();
            }
            ord.TimeOrder = System.DateTime.Now;
            db.Orders.Add(ord);
            db.SaveChanges();

            foreach (var item in carts)
            {
                PizzaContainsInOrder inv = new PizzaContainsInOrder();

                inv.IdPizza = item.productid;
                inv.Amount = item.qty;
                inv.IdOrder = piz.MaxValue();
                db.PizzaContainsInOrders.Add(inv);
                db.SaveChanges();

            }

            TempData.Remove("total");
            TempData.Remove("Cart");
            TempData["msg"] = "Заказ успешно совершен!";
            TempData.Keep();

            return RedirectToAction("Index");
        }

    }
}
