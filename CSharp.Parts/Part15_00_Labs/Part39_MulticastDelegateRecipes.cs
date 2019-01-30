using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // 
    public delegate void SampleDelegate();


    // Main_Helper - Client
    class Part39_MulticastDelegateRecipes
    {
        public static void Part39_Lab()
        {
            Console.WriteLine("Multi-cast Delegate in C#");

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample method one invoked");
        }



    }
}
