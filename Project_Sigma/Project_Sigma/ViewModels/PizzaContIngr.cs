using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.ViewModels
{
    public class PizzaContIngr
    {
        [DisplayName("Вес")]
        public double Weight { get; set; }
        [DisplayName("Название пиццы")]
        public int IdPizza { get; set; }

        public List<Pizza> Pizza { get; set; }
        [DisplayName("Название ингредиента")]
        public int IdIngredient { get; set; }
        public List<Ingredient> Ingredient { get; set; }
        public virtual Ingredient IdIngredientNavigation { get; set; }
        public virtual Pizza IdPizzaNavigation { get; set; }
    }
}
