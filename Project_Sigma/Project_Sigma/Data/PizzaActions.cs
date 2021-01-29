using Project_Sigma.Interface;
using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class PizzaActions : IPizza
    {
        private readonly ProjectSigmaContext _context;
        
        public PizzaActions(ProjectSigmaContext context)
        {
            _context = context;
        }
        public void DeletePizza(Pizza pizza)
        {
            _context.Pizzas.Remove(pizza);
        }

        public List<Pizza> GetAllPizza()
        {
            return _context.Pizzas.ToList();   
        }

        public void InsertPizza(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdatePizza(Pizza pizza)
        {
            _context.Pizzas.Update(pizza);
        }
    }
}
