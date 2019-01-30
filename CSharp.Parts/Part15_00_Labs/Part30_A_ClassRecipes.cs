using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    interface ICustomer301
    {
        void Print1();
    }

    interface ICustomer302 : ICustomer301
    {
        void Print2();
    }

    class CustomerP30A : ICustomer302
    {
        public void Print1()
        {
            Console.WriteLine($"Print 1");
        }

        public void Print2()
        {
            Console.WriteLine($"Print 2");
        }
    }


    class Part30_A_ClassRecipes
    {
        public static void Part30_A_Lab()
        {
            Console.WriteLine($"\nInterface can Inherit from another Interface\n========================");

            Console.WriteLine("\nCustomerP30A instance\n==========");
            CustomerP30A C1 = new CustomerP30A();
            C1.Print1();
            C1.Print2();

            // 
            Console.WriteLine("\nICustomer301 instance\n==========");
            ICustomer301 Cust = new CustomerP30A();  // A parent class reference variable can point to a child class object.
            Cust.Print1();

            Console.WriteLine("\nICustomer302 instance\n==========");
            ICustomer302 cust1 = new CustomerP30A();
            cust1.Print2();
            cust1.Print1();
        }
    }
}
