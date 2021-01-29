using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class PizzaContainsInOrder
    {
        public int Amount { get; set; }
        public int IdPizza { get; set; }
        public int IdOrder { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Pizza IdPizzaNavigation { get; set; }
    }
}
