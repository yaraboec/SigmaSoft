using System;
using System.Collections.Generic;

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
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MiddleName { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public double Skidka { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
