using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Linq.Parts.Part2_Linq_Intro
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputString;
        }
    }

    public class ExtensionMethodLab
    {
        public static void Extension_Lab()
        {
            Console.WriteLine($"\nExtension Method - Change the case of the first character");

            string strName = "joseph";
            string result = strName.ChangeFirstLetterCase();
            //string result = StringHelper.ChangeFirstLetterCase(strName);

            Console.WriteLine($"{result}");
        }

        public static void Extension_Lab2()
        {
            Console.WriteLine($"\nLinq Extension Method 2");

            List<int> Numbers = ExtensionMethodLab.NumberList();

            IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);

            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine($"{evenNumber}");
            }
        }

        public static void Extension_Lab3()
        {
            Console.WriteLine($"\nLinq Extension Method 3");

            List<int> Numbers = ExtensionMethodLab.NumberList();

            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);

            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine($"{evenNumber}");
            }
        }

        public static List<int> NumberList()
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return integers;
        }
    }

}
