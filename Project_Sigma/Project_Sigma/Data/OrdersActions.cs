using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class OrdersActions
    {
        private readonly ProjectSigmaContext _context;

        public OrdersActions(ProjectSigmaContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

    }
}
