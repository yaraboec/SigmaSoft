using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Data
{
    public class IngredActions
    {
        private readonly ProjectSigmaContext _context;

        public IngredActions(ProjectSigmaContext context)
        {
            _context = context;
        }
        public List<Ingredient> GetAllIngred()
        {
            return _context.Ingredients.ToList();
        }
    }
}
