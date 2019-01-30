using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2
    {
        void Print2();
    }

    class CustomerP30 : ICustomer1, ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine($"I2 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface Print Method");
        }
    }

    class Part30_ClassRecipes
    {
        public static void Part30_Lab()
        {
            Console.WriteLine($"\nInterface in C#\n========================");

            CustomerP30 C1 = new CustomerP30();
            C1.Print1();
        }
    }
}
