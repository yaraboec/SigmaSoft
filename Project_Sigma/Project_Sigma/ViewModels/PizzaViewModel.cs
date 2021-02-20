using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Project_Sigma.ViewModels
{
    public class PizzaViewModel
    {
        public int IdPizza { get; set; }
        [Required]
        [DisplayName("Название пиццы")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Цена за работу")]
        public int PriceWork { get; set; }

        [DisplayName("Изображение")]
        public IFormFile Img { get; set; }

        public IEnumerable<SelectListItem> SelectListItems { get; set; }
    }
}
