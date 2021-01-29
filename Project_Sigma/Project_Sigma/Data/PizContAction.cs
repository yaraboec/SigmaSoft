using Microsoft.Data.SqlClient;
using Project_Sigma.Models;
using Project_Sigma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class PizContAction
    {
        private readonly ProjectSigmaContext _context;

        public PizContAction(ProjectSigmaContext context)
        {
            _context = context;
        }
        public List<PizzaContainIngr> GetAll()
        {
            return _context.PizzaContainIngrs.ToList();
        }
        public int MaxValue()
        {
            int max;
            max = _context.Orders.Max(x => x.IdOrder);
            return max;
        }
    }
}
