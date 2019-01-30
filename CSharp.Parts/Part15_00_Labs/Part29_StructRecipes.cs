using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Customer29
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }


    class Part29_StructRecipes
    {
        public static void Part29_Lab()
        {
            Console.WriteLine($"\nDifferences Between Classes And Struct\n==================");

            // A demo as to how the variables{int and Customer29} get created in memory
            int i = 0;

            if (i == 10)
            {
                int j = 20;                       // variable j and c1 lifespan are only within the scope of this if block and get destroyed outside this scope
                Customer29 C1 = new Customer29(); // the customer object "new Customer29" get stored on the heap and later destroed by the garbage collector
                C1.ID = 101;
                C1.Name = "Mark";
            }           
        }

        public static void Part29_A_Lab()
        {
            Console.WriteLine($"\nValue type Demo\n===========");
            int i = 10;   // i = 10
            int j = i;    // j = 10
            j = j + 1;    // j = 11

            Console.WriteLine($" i = {i} && j = {j}");    // i = 10, j = 11
        }

        public static void Part29_B_Lab()
        {
            Console.WriteLine($"\nReference type Demo\n=============");

            Customer29 C1 = new Customer29();
            C1.ID = 101;
            C1.Name = "Mark";

            Customer29 C2 = C1;   // copy c1 to c2 i.e c1 now point to c2 i.e c1 has the same data as c2

            C2.Name = "Mary";

            Console.WriteLine($"C1.Name = {C1.Name} && C2.Name = {C2.Name }");
        }

    }
}
