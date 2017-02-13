using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExcersiceConsoleApp
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int PizzaID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
