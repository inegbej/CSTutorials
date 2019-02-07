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
                catch (Exception ex)   
                {
                    string filePath = @"E:\LocalOnly\Data\Log.txt";  
                    if (File.Exists(filePath))                       
                    {
                        StreamWriter sw = new StreamWriter(filePath);              
                        sw.Write(ex.GetType().Name);                               
                        sw.WriteLine();                                            
                        sw.Write(ex.Message);                                      
                        sw.Close();                                               
                        Console.WriteLine("There is a problem, Please try later.");   
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);   
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
