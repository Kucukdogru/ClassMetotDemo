using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{
                CustomerId = 1,
                CustomerName = "Merve",
                CustomerSurname= "KÜÇÜKDOĞRU",
                CustomerJob = "Computer Engineer",
                Email= "kucukdogrumerve@gmail.com",
                PhoneNumber="12345645664"
            };

            Customer customer2 = new Customer
            {
                CustomerId = 2,
                CustomerName = "Meryem",
                CustomerSurname = "YILMAZ",
                CustomerJob = "Computer Engineer",
                Email = "meryem@gmail.com",
                PhoneNumber = "98765432131"
            };

            Console.WriteLine("*******************Single Customer Information List***************");
            CustomerManager customerManager = new CustomerManager();
            customerManager.GetCustomer(customer1);



            Console.WriteLine("\n**********************Customer Add and List**********************");
            CustomerManager customerManager2 = new CustomerManager();
            Customer new_customer = new Customer(); 
            new_customer= customerManager2.AddCustomer();
            customerManager2.GetCustomer(new_customer);


            Console.WriteLine("\n**************************All Customer List***********************");
            CustomerManager customerManager3 = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, new_customer };
            customerManager3.GetListCustomer(customers);
            
            
            Console.WriteLine("\n**************************Delete Single Customer***********************");
            CustomerManager customerManager4 = new CustomerManager();
            customerManager4.DeleteCustomer(customer2.CustomerId);



        }
    }
}
