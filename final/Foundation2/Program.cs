using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        List<Customer> customers  = new List<Customer>{};
        List<Order> orders  = new List<Order>{};
        

        CreateSomeCustomers();
        CreateSomeOrders();
        
        Console.Clear();
        int i = 1;
        Console.WriteLine($"---------------------------------------------------------------------");
        foreach( Order o in orders){
            double shippingCost = 0;

            Console.WriteLine($"Order No. {i}");
            Console.WriteLine($"PAKICKING LIST:"); 
            Console.WriteLine("");
            Console.WriteLine($"{o.PackingList()}");  
            Console.WriteLine(""); 
            Console.WriteLine($"Sub-Total {o.SubTotalCostOfTheOrder()}");
            

            shippingCost =  o.GetShippingCost(customers[o.GetCustomerID()]);

            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"Shipping cost: ${shippingCost}"); 
            Console.ResetColor();                  
            Console.WriteLine("");
            Console.WriteLine($"Total for this order  {o.SubTotalCostOfTheOrder() + shippingCost}");                   

            Console.WriteLine($"\n\n\n\tSHIPPING LABEL");
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{o.ShippingLabel(customers[o.GetCustomerID()])}");  
            Console.ResetColor();
            i++;
            Console.WriteLine($"---------------------------------------------------------------------");
        }



 
        void CreateSomeOrders(){
            List<Product> products_order1  = new List<Product>{};
            List<Product> products_order2  = new List<Product>{};
            
            //Order 1
            Order o1 = new Order();
            Product p1 = new Product(1,"RTX 4090",1999.99,1);
            Product p2 = new Product(2,"Rubik's cube",16.5,2);
            Product p3 = new Product(3,"Moniter",157.6,2);


            products_order1.Add(p1);
            products_order1.Add(p2);
            products_order1.Add(p3);

            o1.SetCustomerID(1);
            o1.SetProducts(products_order1);
            orders.Add(o1);

           //Order 2

            Order o2 = new Order();
            Product p4 = new Product(4, "Arugula Rocket", 8.50, 7);
            Product p5 = new Product(5, "Thai Basil", 6.75, 3);
            Product p6 = new Product(6, "Lasagna", 9.99, 4);
            Product p7 = new Product(7, "Butternut Squash", 3.75, 10);

            products_order2.Add(p4);
            products_order2.Add(p5);
            products_order2.Add(p6);
            products_order2.Add(p7);            
            
            o2.SetCustomerID(4);
            o2.SetProducts(products_order2);
            orders.Add(o2);
        }


        void CreateSomeCustomers(){
            Address address1 = new Address("987 Elm St", "San Diego", "CA", 54321, "US");
            Address address2 = new Address("364 S 1st W", "Rexburg", "ID", 83440, "US");
            Address address3 = new Address("456 Cedar St", "Provo", "UT", 24680, "US");
            Address address4 = new Address("Calle Revolución", "Ensenada", "", 12345, "Brazil");
            Address address5 = new Address("178 Royale statue", "Kathmandu", "", 1000, "Nepal");
    
            Customer customer1 = new Customer(1, "Michael Johnson", address1);
            Customer customer2 = new Customer(2, "Emily Davis", address2);
            Customer customer3 = new Customer(3, "David Lee", address3);
            Customer customer4 = new Customer(4, "Sophia Martinez", address4);
            Customer customer5 = new Customer(5, "Ram Khadka", address5);
        
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
        }




    }
}