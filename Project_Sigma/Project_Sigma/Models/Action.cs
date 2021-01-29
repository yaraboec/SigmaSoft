using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class Action
    {
        public Action()
        {
            Orders = new HashSet<Order>();
        }

        public int IdAction { get; set; }
        public string Name { get; set; }
        public double PercentSkidki { get; set; }
        public TimeSpan EndAction { get; set; }
        public TimeSpan BeginAction { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
