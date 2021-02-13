using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int IdClient { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Email { get; set; }
        public double Skidka { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
