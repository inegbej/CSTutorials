/* Differences Between Method overriding and method hiding. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base class Print Method");
        }
    }


    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a derived class Print Method");
        }
    }


    class Part24_00_ClassRecipes
    {
        public static void Part24_Lab()
        {
            Console.WriteLine($"\nMethod overriding Demo\n========================");

            BaseClass B = new DerivedClass();    // In this scenario the "derived" class Print() method is called. Because we use virtual and override
            B.Print();
        }
    }
}
