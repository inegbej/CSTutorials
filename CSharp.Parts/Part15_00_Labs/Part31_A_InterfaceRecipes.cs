/* When using Explicit Interface implementation, 1) you cannot use access modifiers, 2) you have to use the interface name followed by a dot */ 
using System;

namespace CSharp.Parts.Part15_00_Labs
{

    class Part31_A_InterfaceRecipes : I1, I2
    {        
        void I1.InterfaceMethod() 
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        public static void Part31_A_A_Lab()
        {
            Console.WriteLine($"\nInterface Explicit Implementation Demo \n========================");            

            Part31_A_InterfaceRecipes P = new Part31_A_InterfaceRecipes();
            ((I1)P).InterfaceMethod();              // One way to invoke an explicit interface members is through the interface reference variable ((I1)P).InterfaceMethod() i.e typecasting. You cannot invoke them on the class reference variable or P.InterfaceMethod();.
            ((I2)P).InterfaceMethod();
        }

        public static void Part31_A_B_Lab()
        {
            Console.WriteLine($"\nInterface Explicit Implementation Demo \n========================");

            I1 i1 = new Part31_A_InterfaceRecipes();
            I2 i2 = new Part31_A_InterfaceRecipes();

            i1.InterfaceMethod();                  // another option of invoking an interface member
            i2.InterfaceMethod();
        }
                
    }
}
