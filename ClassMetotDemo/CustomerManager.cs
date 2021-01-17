using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void GetCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerSurname);
            Console.WriteLine(customer.CustomerJob);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.PhoneNumber);

        }

        public void GetListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.CustomerJob);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.PhoneNumber);
            }
        }

        public Customer AddCustomer()
        {
            Customer customer = new Customer {
                CustomerId = 3,
                CustomerName = "Ayşe",
                CustomerSurname = "AY",
                CustomerJob = "Nurse",
                Email = "ayse@gmail.com",
                PhoneNumber = "25468792452"
            };
            return customer;            
        }
    }
}
