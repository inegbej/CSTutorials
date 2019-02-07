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


    class Part34_MultipleInheritanceProblemRecipes
    {
        public static void Part33_Lab()
        {
            Console.WriteLine($"\nProblem with multiple class inheritance\n========================");

        }
    }
}
