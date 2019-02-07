using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Part15_00_Recipes
    {
        public static void Part16_Lab()
        {
            Console.WriteLine("\nMethods in C#\n=============");
            Console.WriteLine("\nPrint Even Numbers\n==============");

            int Start = 0;    

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        public static void Part16_A_Lab(int tarGet)
        {
            Console.WriteLine("\nMethods in C# - Even Numbers with parameter\n=============");

            int Start = 0;   

            while (Start <= tarGet)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

        public static void Part16_B_Helper_Lab()
        {
            Console.WriteLine("\nMethods in C# - Add 2 Numbers\n=============");

            int Sum = Part15_00_Recipes.Part16_B_Lab(10, 20);
            Console.WriteLine($"Sum = {Sum}.");
        }
        
        public static int Part16_B_Lab(int FN, int SN)
        {
            return FN + SN;
        }


        public static void Part17_A_Helper_Lab()
        {
            Console.WriteLine("\nMethods Parameter By value\n=============");

            int i = 0;

            Part17_Lab(i);

            Console.WriteLine(i);
        }
       
        public static void Part17_Lab(int j)
        {
            j = 100;
        }
        
        public static void Part17_B_Helper_Lab()
        {
            Console.WriteLine("\nMethods Parameter By reference\n=============");

            int i = 0;

            Part17_B_Lab(ref i);

            Console.WriteLine(i);
        }
        
        public static void Part17_B_Lab(ref int j)
        {           
            j = 100;
        }
        
        public static void Part17_C_Helper_Lab()
        {
            Console.WriteLine("\nMethods - Out Parameter Demo\n==================");

            int Total = 0;
            int Product = 0;
            Part17_C_Lab(10, 20, out Total, out Product);

            Console.WriteLine($"Sum = {Total} && Product = {Product}");
        }
        // A function that add 2 numbers and return their Sum. Return both Sum and Product. Method that returns 2 values
        public static void Part17_C_Lab(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        public static void Part17_D_Helper_Lab()
        {
            Console.WriteLine("\nMethods - Parameter Arrays Demo\n==================");

            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //Part17_D_Lab();                         
            //Part17_D_Lab(Numbers);
            Part17_D_Lab(1, 2, 3, 4, 5, 6, 7, 8, 9);  
        }
        // 
        public static void Part17_D_Lab(params int[] Numbers)     
        {
            Console.WriteLine($"There are {Numbers.Length} element in the array");

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        
        // Loop through an array in a reverse order.
        public static void Lab()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Array output: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);
            }

            Console.WriteLine("\n");

            // reverse the array
            Console.Write("Reversed: ");
            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }

        public static void Part18_Lab()
        {
            Console.WriteLine("\nNamespace Demo\n==================");

            PATA.ClassA.Print();
            PATB.ClassA.Print();           
        }
        
                
    }
}


namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method.");
            }
        }
    }
}


namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method.");
            }
        }
    }
}

