using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Name { get; set; }
        [Required]
        public double PercentSkidki { get; set; }
        [Required]
        public TimeSpan EndAction { get; set; }
        [Required]
        public TimeSpan BeginAction { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
