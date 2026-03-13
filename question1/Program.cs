using System;
using System.Collections.Generic;

class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();
    static int orderCounter = 1;

    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("Delicious Churros:");
            Console.WriteLine("1. Place order");
            Console.WriteLine("2. Deliver order");
            Console.WriteLine("0. Exit");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out option)){
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    PlaceOrder();
                    break;

                case 2:
                    DeliverOrder();
                    break;
                
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (option != 0);
    }

    static void PlaceOrder()
    {
        Console.WriteLine("Select Churros:");
        Console.WriteLine("1. Plain Sugar (€6)");
        Console.WriteLine("2. Cinnamon Sugar (€6)");
        Console.WriteLine("3. Chocolate (€8)");
        Console.WriteLine("4. Nutella (€8)");

        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        double price = (choice <= 2) ? 6 : 8;

        Order order = new Order(orderCounter, "Churros", qty);
        double bill = order.PayBill(price);

        orderQueue.Enqueue(order);

        Console.WriteLine($"Order placed. Order No: {orderCounter}");
        Console.WriteLine($"Total Bill: €{bill}");

        orderCounter++;
    }

    static void DeliverOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("No orders in queue.");
            return;
        }

        Order order = orderQueue.Dequeue();
        order.CollectOrder();
    }
}
