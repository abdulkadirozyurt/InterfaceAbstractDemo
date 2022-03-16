using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer();


            customerManager.Save(new Customer { DateOfBirth = new DateTime(2002), FirstName = "Abdulkadir", LastName = "Özyurt", NationalityId = "46957819302" });


            Console.ReadLine();

        }
    }
}
