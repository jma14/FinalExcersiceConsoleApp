using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExcersiceConsoleApp
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string PizzaType { get; set; }
        public decimal PizzaCost { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
