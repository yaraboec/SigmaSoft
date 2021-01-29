using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Project_Sigma.ViewModels
{
    public class PizzaViewModel
    {
        public int IdPizza { get; set; }
        public string Name { get; set; }
        public int PriceWork { get; set; }
        public IFormFile Img { get; set; }

        public IEnumerable<SelectListItem> SelectListItems { get; set; }
    }
}
