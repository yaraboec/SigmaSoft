using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class OrdContPiz
    {
        private readonly ProjectSigmaContext _context;

        public OrdContPiz(ProjectSigmaContext context)
        {
            _context = context;
        }

        public List<PizzaContainsInOrder> GetAll()
        {
            return _context.PizzaContainsInOrders.ToList();
        }
    }
}
