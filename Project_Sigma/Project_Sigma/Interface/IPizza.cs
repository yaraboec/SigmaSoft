using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.Interface
{
    public interface IPizza
    {
        List<Pizza> GetAllPizza();
        void InsertPizza(Pizza pizza);
        void UpdatePizza(Pizza pizza);
        void DeletePizza(Pizza pizza);
        void Save();

    }
}
