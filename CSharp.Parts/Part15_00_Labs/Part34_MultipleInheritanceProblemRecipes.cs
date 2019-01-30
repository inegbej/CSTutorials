using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    class A_Part34
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B_Part34 : A_Part34
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }

    class C_Part34 : A_Part34
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    // This class will cause ambiguity - This is called diamond problem because of the shape of the problem which is why csharp does not support multiple inheritance.
    //class D_Part34 : B_Part34, C_Part34
    //{        
    //}


    class Part34_MultipleInheritanceProblemRecipes
    {
        public static void Part33_Lab()
        {
            Console.WriteLine($"\nProblem with multiple class inheritance\n========================");

            //D_Part34 d = new D_Part34();
            //d.Print();                    // This is an ambiguity, is the Print() method from B_Part34 or C_Part34 - This is called diamond problem because of the shape of the problem.
        }
    }
}
