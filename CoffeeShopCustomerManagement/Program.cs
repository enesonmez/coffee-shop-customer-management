using System;

namespace CoffeeShopCustomerManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1998, 11, 12),
                FirstName = "Enes",
                LastName = "Sönmez",
                NationalityId = "44428837022"
            });
            Console.ReadLine();
        }
    }
}