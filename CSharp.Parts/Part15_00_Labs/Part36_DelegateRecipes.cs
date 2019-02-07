using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    // Delegate
    public delegate void HelloFunctionDelegate(string Message);

    class Part36_DelegateRecipes
    {        
        public static void Part36_Lab()
        {
            Console.WriteLine("\nIntro to Delegate in c#\n=================");

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);    
            del("Hello from delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
}
