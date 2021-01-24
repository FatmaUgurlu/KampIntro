using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Fatma";
            customer1.Surname = "Uğurlu";
            customer1.IdentityNo = "11111111111";
            customer1.PhoneNumber = "05554443333";
            customer1.CustumerNo = "12345";


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Emre";
            customer2.Surname = "Pelvan";
            customer2.IdentityNo = "22222222222";
            customer2.PhoneNumber = "05556667777";
            customer2.CustumerNo = "12346";


            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Ayşe";
            customer3.Surname = "Bedel";
            customer3.IdentityNo = "33333333333";
            customer3.PhoneNumber = "5558889999";
            customer3.CustumerNo = "12347";


            Customer [] customers = new Customer []{ customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);


            Console.WriteLine("***************************");

            
            customerManager.List(customers);

            Console.WriteLine("***************************");

            customerManager.Delete(customer1);
           


        }
    }
}
