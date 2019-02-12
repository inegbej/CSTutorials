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

        public static void SumOfNumberWithoutLinq_Lab9()
        {
            Console.WriteLine("\nWithout Linq Aggregate - Find Sum of number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = 0;

            foreach (int i in Numbers)
            {
                result = result + i;
            }

            Console.WriteLine($"Sum of number = {result}");
        }

        public static void SumOfNumberWithLinq_Lab10()
        {
            Console.WriteLine("\nWith Linq Aggregate - Find sum of number");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Sum();

            Console.WriteLine($"Sum of number = {result}");
        }

        public static void SumOfEvenNumberWithoutLinq_Lab11()
        {
            Console.WriteLine("\n Find Sum of even number without linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = 0;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    result = result + i;
                }               
            }

            Console.WriteLine($"Sum of even number = {result}");
        }

        public static void SumOfEvenNumberWithLinq_Lab12()
        {
            Console.WriteLine("\n Find sum of even number with linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine($"Sum of even number = {result}");
        }

        public static void CountOfNumberWithoutLinq_Lab13()
        {
            Console.WriteLine("\n Find count of number without linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = 0;

            foreach (int i in Numbers)
            {                
                result = result + 1;               
            }

            Console.WriteLine($"Count of number = {result}");
        }

        public static void CountOfNumberWithLinq_Lab14()
        {
            Console.WriteLine("\n Find count of number with linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Count();

            Console.WriteLine($"Count of number = {result}");
        }

        public static void CountOfEvenNumberWithoutLinq_Lab15()
        {
            Console.WriteLine("\n Find count of even number without linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int? result = 0;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    result = result + 1;
                }
                
            }

            Console.WriteLine($"Count of even number = {result}");
        }

        public static void CountOfEvenNumberWithLinq_Lab16()
        {
            Console.WriteLine("\n Find count of even number with linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            int result = Numbers.Where(x => x % 2 == 0).Count();

            Console.WriteLine($"Count of even number = {result}");
        }

        public static void AvgOfNumberWithoutLinq_Lab17()
        {
            Console.WriteLine("\n Find avg of number without linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            double? sum = 0;
            int total = 0;
            double? result = 0;

            foreach (int i in Numbers)
            {
                sum = sum + i;
                total = total + 1;
            }
            result = sum / total;

            Console.WriteLine($"Avg of number = {result}");
        }

        public static void AvgOfNumberWithLinq_Lab18()
        {
            Console.WriteLine("\n Find avg of number with linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            double result = Numbers.Average();

            Console.WriteLine($"Avg of number = {result}");
        }

        public static void AvgOfEvenNumberWithoutLinq_Lab19()
        {
            Console.WriteLine("\n Find avg of even number without linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            double? sum = 0;
            int total = 0;
            double? result = 0;

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    total = total + 1;
                }                
            }
            result = sum / total;

            Console.WriteLine($"Avg of even number = {result}");
        }

        public static void AvgOfEvenNumberWithLinq_Lab20()
        {
            Console.WriteLine("\n Find avg of even number with linq");

            int[] Numbers = Part1_Linq_Labs.NumArray();

            double result = Numbers.Where(x => x % 2 == 0).Average();

            Console.WriteLine($"Avg of even number = {result}");
        }

        public static void ShortCountryNameAndCharacterWithoutLinq_Lab21()
        {
            Console.WriteLine("\n Find Short Country Name and Character without linq");

            string[] countries = Part1_Linq_Labs.StringArray();

            int? result = null;

            foreach (string str in countries)
            {
                if (!result.HasValue || str.Length < result)
                {
                    result = str.Length;
                }
            }
           
            Console.WriteLine($"The shortest country name has {result} Character");
        }

        public static void ShortCountryNameAndCharacterWithLinq_Lab22()
        {
            Console.WriteLine("\n Find Short Country Name and Character with linq");

            string[] countries = Part1_Linq_Labs.StringArray();

            int result = countries.Min(country => country.Length);

            Console.WriteLine($"The shortest country name has {result} Character");
        }

        public static void LongestCountryNameWithoutLinq_Lab23()
        {
            Console.WriteLine("\n Find longest Country name without linq");

            string[] countries = Part1_Linq_Labs.StringArray();

            int? result = null;

            foreach (string str in countries)
            {
                if (!result.HasValue || str.Length > result)
                {
                    result = str.Length;
                }
            }

            Console.WriteLine($"The longest country name has {result} Character");
        }

        public static void LongestCountryNameWithLinq_Lab24()
        {
            Console.WriteLine("\n Find longest Country name  with linq");

            string[] countries = Part1_Linq_Labs.StringArray();

            int result = countries.Max(country => country.Length);

            Console.WriteLine($"The longest country name has {result} Character");
        }


        public static int[] NumArray()
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return integers;
        }

        public static string[] StringArray()
        {
            string[] countries = { "India", "USA", "UK" };

            return countries;
        }

        

    }
}
