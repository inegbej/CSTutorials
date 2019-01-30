using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public class Part41_00_InnerExceptionRecipes
    {
        // Inner Exception Demo: Logging or emailing exception BUt overwriting existing exception
        public static void InnerException_Lab()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    //int FN = Convert.ToInt32(Console.ReadLine());
                    int FN = 10;

                    Console.WriteLine("Enter Second Number");
                    //int SN = Convert.ToInt32(Console.ReadLine());
                    int SN = 0;

                    int Result = FN / SN;

                    Console.WriteLine($"Result = {Result}");

                }
                catch (Exception ex)   // catch exception and try to log it - 1st exception
                {
                    string filePath = @"E:\LocalOnly\Data\Log.txt";  // Location of the log file
                    if (File.Exists(filePath))                       // This will throw another exception if file does not exist - 2nd exception
                    {
                        StreamWriter sw = new StreamWriter(filePath);              // Pass the log file to the streamwriter
                        sw.Write(ex.GetType().Name);                               // Write the exception, type and fully qualified Name of exception to the log file 
                        sw.WriteLine();                                            // A line break
                        sw.Write(ex.Message);                                      // exception message
                        sw.Close();                                                // close the stream
                        Console.WriteLine("There is a problem, Please try later.");   // tell the user of error
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);   // Throw another 2nd FileNotFoundException exception and pass in the 1st/original/inner "ex" exception
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)  // always check the inner exception
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
                }               
            }

        }

    }
}
