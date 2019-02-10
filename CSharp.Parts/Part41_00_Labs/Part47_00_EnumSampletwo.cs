using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public enum Gender47
    {
        Unknown,
        Male,
        Female
    }

    public class Part47_00_EnumSampletwo
    {
        public static void Enum_Lab47()
        {
            Console.WriteLine($"\nEnums in C#\n=======");

            int[] values = (int[])Enum.GetValues(typeof(Gender47));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
