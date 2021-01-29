using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            PizzaContainIngrs = new HashSet<PizzaContainIngr>();
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int IdIngredient { get; set; }

        public virtual ICollection<PizzaContainIngr> PizzaContainIngrs { get; set; }
    }
}
