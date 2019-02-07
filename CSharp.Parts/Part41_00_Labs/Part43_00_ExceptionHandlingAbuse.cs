using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public class ExceptionAbusedemo
    {
       
    }


    public class Part43_00_ExceptionHandlingAbuse
    {
        public static void ExceptionAbuse()
        {
            Console.WriteLine($"Exception abuse Demo");

            try
            {
                Console.WriteLine($"Please enter Numerator");
                //int Numerator = Convert.ToInt32(Console.ReadLine());
                int Numerator = 10;

                Console.WriteLine($"Please enter Denominator");
                //int Denominator = Convert.ToInt32(Console.ReadLine());
                int Denominator = 5;

                int Result = Numerator / Denominator;
                Console.WriteLine($"Result = {Result}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Only numbers between {Int32.MinValue} && {Int32.MaxValue} are allowed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
