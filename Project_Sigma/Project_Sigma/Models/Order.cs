using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class Order
    {
        public Order()
        {
            PizzaContainsInOrders = new HashSet<PizzaContainsInOrder>();
        }

        public double Sum { get; set; }
        public int IdOrder { get; set; }
        public DateTime TimeOrder { get; set; }
        public double Skidka { get; set; }
        public int IdClient { get; set; }
        public int? IdAction { get; set; }

        public virtual Action IdActionNavigation { get; set; }
        public virtual Client IdClientNavigation { get; set; }
        public virtual ICollection<PizzaContainsInOrder> PizzaContainsInOrders { get; set; }
    }
}
