using Project_Sigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Sigma.ViewModels
{
    public class ActionViewModel
    {
        public int IdAction { get; set; }
        public string Name { get; set; }
        public double PercentSkidki { get; set; }
        public TimeSpan EndAction { get; set; }
        public TimeSpan BeginAction { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
