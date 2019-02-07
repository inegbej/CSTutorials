using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // 
    public delegate void SampleDelegatePart39A();


    class Part39_A_MulticastDelegateRecipes
    {
        public static void Part39_A_Lab()
        {
            Console.WriteLine("Multi-cast Delegate in C#");

            SampleDelegatePart39A del1, del2, del3, del4;

            del1 = new SampleDelegatePart39A(SampleMethodOne);
            del2 = new SampleDelegatePart39A(SampleMethodTwo);
            del3 = new SampleDelegatePart39A(SampleMethodThree);

            del4 = del1 + del2 + del3 - del2;  
            del4();                            
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
