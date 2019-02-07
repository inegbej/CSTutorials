using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public class Part44_00_ExceptionHandlingSolved
    {
        public static void ExceptionAbuseSolved()
        {
            Console.WriteLine($"Exception abuse solved Demo");

            try
            {
                Console.WriteLine($"Please enter Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
                
                if (IsNumeratorConversionSuccessful)
                {
                    Console.WriteLine($"Please enter Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                   
                    if (IsDenominatorConversionSuccessful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine($"Result = {Result}");
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine($"Denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine($"Denominator should be a valid number between {Int32.MinValue} && {Int32.MaxValue} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Numerator should be a valid number between {Int32.MinValue} && {Int32.MaxValue} ");
                }
            }           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
