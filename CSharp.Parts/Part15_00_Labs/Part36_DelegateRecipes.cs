using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // Delegate
    public delegate void HelloFunctionDelegate(string Message);


    // MainHelper - Client
    class Part36_DelegateRecipes
    {        
        public static void Part36_Lab()
        {
            Console.WriteLine("\nIntro to Delegate in c#\n=================");

            // A delegate is a type safe function pointer
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);    // create a delegate object and pass it a method, and execute the delegate.
            del("Hello from delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
}
