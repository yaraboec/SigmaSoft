using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class PizzaContainIngr
    {
        public double Weight { get; set; }
        public int IdPizza { get; set; }
        public int IdIngredient { get; set; }
        public virtual Ingredient IdIngredientNavigation { get; set; }
        public virtual Pizza IdPizzaNavigation { get; set; }
    }
}
