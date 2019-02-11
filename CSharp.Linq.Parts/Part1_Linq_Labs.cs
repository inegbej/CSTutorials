using System;
using System.Linq;

namespace CSharp.Linq.Parts
{
    public class Part1_Linq_Labs
    {
        // Main
        public static void SmallestNumberWithoutLinq_Lab()
        {
            Console.WriteLine("\nWithout Linq Aggregate - Find smallest number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = null;

            foreach (int i in Numbers)
            {
                if (!result.HasValue || i < result)
                {
                    result = i;
                }
            }

            Console.WriteLine($"Smalleest number = {result}");            
        }
                
        // 
        public static void SmallestNumberWithLinq_Lab2()
        {
            Console.WriteLine("\nWith Linq Aggregate - Find smallest number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Min();

            Console.WriteLine($"Smalleest number = {result}");


        }
       
        // 
        public static void SmallestEvenNumberWithoutLinq_Lab3()
        {
            Console.WriteLine("\nWithout Linq Aggregate - Find smallest even number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = null;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    if (!result.HasValue || i < result)
                    {
                        result = i;
                    }
                }               
            }

            Console.WriteLine($"Smalleest even number = {result}");
        }

        public static void SmallestEvenNumberWithLinq_Lab4()
        {
            Console.WriteLine("\nWith Linq Aggregate - Find smallest even number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Where(x => x % 2 == 0).Min();

            Console.WriteLine($"Smalleest even number = {result}");
        }

        public static void LargestNumberWithoutLinq_Lab5()
        {
            Console.WriteLine("\nWithout Linq Aggregate - Find largest number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = null;

            foreach (int i in Numbers)
            {
                if (!result.HasValue || i > result)
                {
                    result = i;
                }
            }

            Console.WriteLine($"Largest number = {result}");
        }

        public static void LargestNumberWithLinq_Lab6()
        {
            Console.WriteLine("\nWith Linq Aggregate - Find largest number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Max();
                        
            Console.WriteLine($"Largest number = {result}");
        }

        public static void LargestEvenNumberWithoutLinq_Lab7()
        {
            Console.WriteLine("\nWithout Linq Aggregate - Find largest even number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = null;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    if (!result.HasValue || i > result)
                    {
                        result = i;
                    }
                }                
            }

            Console.WriteLine($"Largest even number = {result}");
        }

        public static void LargestEvenNumberWithLinq_Lab8()
        {
            Console.WriteLine("\nWith Linq Aggregate - Find largest even number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Where(x => x % 2 == 0).Max();

            Console.WriteLine($"Largest even number = {result}");
        }


        public static int[] NumArray()
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return integers;
        }

        

    }
}
