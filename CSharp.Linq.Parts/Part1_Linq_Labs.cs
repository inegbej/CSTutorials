using System;

namespace CSharp.Linq.Parts
{
    public class Part1_Linq_Labs
    {
        // Main
        public static void Part1Linq_Lab()
        {
            Console.WriteLine("\nWhat is Linq\n=======");

            int[] arr = { 2, -6, 3, 5, 1 };
            int n = arr.Length;
            findElements(arr, n);

        }
        //Helper
        static void findElements(int[] arr, int n)
        {
            // Pick elements one by one and count 
            // greater elements. If count is more 
            // than 2, print that element.
            for (int i = 0; i < n; i++)
            {
                int count = 0;

                for (int j = 0; j < n; j++)
                    if (arr[j] > arr[i])
                        count++;

                if (count >= 2)
                    Console.Write(arr[i] + " ");
            }
        }
        
        // 
        public static void Part1Linq_Lab2()
        {
            Console.WriteLine("\nLab2\n=======");
            

        }
       
        // 
        public static void Part1Linq_Lab3()
        {
            Console.WriteLine("\nLab3\n=======");
        }

        public static void Part1Linq_Lab4()
        {
            Console.WriteLine("\nLab4\n=======");
        }

        

    }
}
