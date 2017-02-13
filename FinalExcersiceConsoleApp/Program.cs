using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExcersiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var customer1 = new Customer
                {
                    CustomerName = "Bill",
                    CustomerAddress = "123 Fake St"
                };

                context.Customers.Add(customer1);

                var customer2 = new Customer
                {
                    CustomerName = "Jim",
                    CustomerAddress = "345 Something Rd"
                };

                context.Customers.Add(customer2);

                var pizza1 = new Pizza
                {
                    PizzaCost = 3M,
                    PizzaType = "VeggieLovers"
                };

                context.Pizzas.Add(pizza1);

                var pizza2 = new Pizza
                {
                    PizzaCost = 5M,
                    PizzaType = "MeatLovers"
                };

                context.Pizzas.Add(pizza2);
                context.SaveChanges();

                var order1 = new Order
                {
                    Customer = customer1,
                    Pizza = pizza1
                };

                context.Orders.Add(order1);

                var order2 = new Order
                {
                    Customer = customer2,
                    Pizza = pizza2
                };

                context.Orders.Add(order2);
                context.SaveChanges();


                var orders = (from o in context.Orders
                              orderby o.OrderID
                              select o).ToList<Order>();

                Console.WriteLine("Orders: ");

                foreach (var ord in orders)
                {
                    Console.WriteLine("OrderID: {0}\nCustomer ID: {1}\nCustomer Name: {2}\nCustomer Address: {3}\nPizza ID: {4}\nPizza Type: {5}\nPizza Cost: {6}\n\n\n",
                        ord.OrderID, ord.Customer.CustomerID, ord.Customer.CustomerName, ord.Customer.CustomerAddress, ord.Pizza.PizzaID, ord.Pizza.PizzaType, ord.Pizza.PizzaCost);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
