using System;

namespace CSharp.Parts.Part15_00_Labs
{
    interface IA
    {
        void AMethod();
    }

    class A_Part35 : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B_Part35 : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    /* This class will have the capabilities of both classes A and B. Multiple class inheritance using Interface*/
    class AB_Part35 : IA, IB
    {
        A_Part35 a = new A_Part35();
        B_Part35 b = new B_Part35();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }


    class Part35_MultipleInterfaceInheritanceRecipes
    {
        public static void Part35_Lab()
        {
            Console.WriteLine($"\nMultiple class inheritance using Interface \n========================");

            AB_Part35 ab = new AB_Part35();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
