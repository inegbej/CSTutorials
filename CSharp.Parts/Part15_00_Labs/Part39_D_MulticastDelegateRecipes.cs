using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // 
    public delegate void SampleDelegatePart39D(out int Integer);


    // Main_Helper - Client
    class Part39_D_MulticastDelegateRecipes
    {
        public static void Part39_D_Lab()
        {
            Console.WriteLine("Multi-cast Delegate in C# - out parameter");

            SampleDelegatePart39D del = new SampleDelegatePart39D(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateOutputParameterValue = -1;

            del(out DelegateOutputParameterValue);

            Console.WriteLine($"Delegate values = {DelegateOutputParameterValue}");
        }

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;  // initialize the output parameter to one
        }

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}
