/* A class implementing 2 interfaces with exactly the same method. */

using System;

namespace CSharp.Parts.Part15_00_Labs
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }


    class Part31_InterfaceRecipes : I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }


        public static void Part31_Lab()
        {
            Console.WriteLine($"\nInterface Implicit Implementation\n========================");

            Part31_InterfaceRecipes P = new Part31_InterfaceRecipes();
            P.InterfaceMethod();            
        }

        public static void Part31_A_Lab()
        {
            Console.WriteLine($"\nInterface Implicit Implementation\n========================");

            Part31_InterfaceRecipes P = new Part31_InterfaceRecipes();
            ((I1)P).InterfaceMethod();                                  // these contain ambiguity
            ((I2)P).InterfaceMethod();
        }

        
    }
}
