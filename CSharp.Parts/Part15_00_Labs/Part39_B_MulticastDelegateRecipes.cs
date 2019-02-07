using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    class Part39_B_MulticastDelegateRecipes
    {
        public static void Part39_B_Lab()
        {
            Console.WriteLine("Multi-cast Delegate in C#");

            SampleDelegatePart39A del = new SampleDelegatePart39A(SampleMethodOne);  
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodOne;     

            del();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample method one invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample method two invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample method three invoked");
        }

    }
}
