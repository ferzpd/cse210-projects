using System;
using System.Collections.Generic;
namespace OnlineOrdering
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("=== Online ordering system ===\n");
    
        Adress adress1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("Calle Mayor 45", "Madrid", "Madrid", "Spain");
            Address address3 = new Address("456 Oak Ave", "Los Angeles", "CA", "USA");
         Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Maria Garcia", address2);
            Customer customer3 = new Customer("Robert Johnson", address3);

             Product product1 = new Product("Laptop", "LAP123", 899.99, 1);
            Product product2 = new Product("Wireless Mouse", "WM456", 29.99, 2);
            Product product3 = new Product("USB-C Cable", "UCC789", 19.99, 3);
            Product product4 = new Product("Smartphone", "SPH999", 699.99, 1);
            Product product5 = new Product("Phone Case", "PHC888", 24.99, 1);
            Product product6 = new Product("Tablet", "TAB777", 349.99, 1);
            Product product7 = new Product("Headphones", "HPH555", 89.99, 2);
             Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);
            
            Order order2 = new Order(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);
            
            Order order3 = new Order(customer3);
            order3.AddProduct(product6);
            order3.AddProduct(product7);
             List<Order> orders = new List<Order> { order1, order2, order3 };
               for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"ORDER #{i + 1}");
                Console.WriteLine("========================================");
                
                Console.WriteLine("\nPACKING LABEL:");
                Console.WriteLine("-------------");
                Console.WriteLine(orders[i].GetPackingLabel());
                
                Console.WriteLine("\nSHIPPING LABEL:");
                Console.WriteLine("---------------");
                Console.WriteLine(orders[i].GetShippingLabel());
                
                Console.WriteLine($"\nTOTAL PRICE: ${orders[i].CalculateTotalCost():F2}");
                Console.WriteLine("\n" + new string('=', 40) + "\n");
            }
            
            Console.WriteLine($"Total Orders Processed: {orders.Count}");
        }
    }
}
    
    