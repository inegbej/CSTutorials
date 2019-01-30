using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // A delegate that returns a value.
    public delegate int SampleDelegatePart39C();

    // Main_Helper - Client
    class Part39_C_MulticastDelegateRecipes
    {
        public static void Part39_C_Lab()
        {
            Console.WriteLine("Multi-cast Delegate in C# - return value");

            SampleDelegatePart39C del = new SampleDelegatePart39C(SampleMethodOne);  
            del += SampleMethodTwo;            
           
            int DelegateReturnValue = del();
            Console.WriteLine($"Delegate values = {DelegateReturnValue}");
        }

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }
               
    }
}
