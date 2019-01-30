/* Default Interface implementation. Implicit implementation*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    class Part31_B_InterfaceRecipes : I1, I2
    {        
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        // Explicit implimemtation, so not a default interface member
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }


        public static void Part31_B_Lab()
        {
            Console.WriteLine($"\nInterface Default Implementation Demo \n========================");

            Part31_B_InterfaceRecipes P = new Part31_B_InterfaceRecipes();

            P.InterfaceMethod();        // default implementation called implicitly

            ((I2)P).InterfaceMethod();  // Explicit implementation called by typecasting

        }

    }
}
