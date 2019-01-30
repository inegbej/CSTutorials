/* NOTE: An abstract class may contain abstract method but not mandatory. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{    
    abstract class Customer_Part32
    {
        public abstract void Print();
    }

    class Part32_AbstractRecipes : Customer_Part32 
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }

        public static void Part32_Lab()
        {
            Console.WriteLine($"\nAbstract class Demo \n========================");

            //Part32_AbstractRecipes P = new Part32_AbstractRecipes();
            Customer_Part32 P = new Part32_AbstractRecipes();
            P.Print();
        }
        
    }

}
