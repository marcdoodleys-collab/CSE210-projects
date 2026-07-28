// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----- Commande 1 : client aux USA -----
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P001", 899.99, 1),
            new Product("Mouse", "P002", 25.50, 2),
            new Product("Keyboard", "P003", 45.00, 1)
        };

        Order order1 = new Order(products1, customer1);

        // ----- Commande 2 : client en Haïti (hors USA) -----
        Address address2 = new Address("45 Rue Capois", "Port-au-Prince", "Ouest", "Haiti");
        Customer customer2 = new Customer("Marc-Doodley Sémétus", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Headphones", "P004", 59.99, 1),
            new Product("Phone Case", "P005", 15.00, 3)
        };

        Order order2 = new Order(products2, customer2);

        // Affichage des résultats pour les deux commandes
        List<Order> orders = new List<Order> { order1, order2 };
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"===== Commande {orderNumber} =====");

            Console.WriteLine("\n--- Étiquette d'emballage ---");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("\n--- Étiquette d'expédition ---");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"\nPrix total : ${order.GetTotalCost():F2}");
            Console.WriteLine();

            orderNumber++;
        }
    }
}