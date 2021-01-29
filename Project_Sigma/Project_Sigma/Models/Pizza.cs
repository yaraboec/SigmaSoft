using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaContainIngrs = new HashSet<PizzaContainIngr>();
            PizzaContainsInOrders = new HashSet<PizzaContainsInOrder>();
        }

        public int IdPizza { get; set; }
        public string Name { get; set; }
        public string Sostav { get; set; }
        public double Weight { get; set; }
        public double ResultPrice { get; set; }
        public int PriceWork { get; set; }
        public string Img { get; set; }
        public virtual ICollection<PizzaContainIngr> PizzaContainIngrs { get; set; }
        public virtual ICollection<PizzaContainsInOrder> PizzaContainsInOrders { get; set; }
    }
}
