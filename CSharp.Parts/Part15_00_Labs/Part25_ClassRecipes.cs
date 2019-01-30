using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    class Part25_ClassRecipes
    {
        //public static void Add(int FN, int LN)
        //{
        //    Console.WriteLine($"Sum = {FN + LN}");
        //}

        public static void Add(float FN, float LN)
        {
            Console.WriteLine($"Sum = {FN + LN}");
        }

        public static void Add(int FN, float LN)
        {
            Console.WriteLine($"Sum = {FN + LN}");
        }


        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine($"Sum = {FN + SN}");
            Sum = FN + SN;
        }




        public static void Part25_Lab()
        {
            Console.WriteLine($"\nMethod overloading in C#\n========================");

            int Sum;
            Add(1, 2, out Sum);
            //Console.WriteLine($"Sum = {Sum}");
            
        }
    }
}
