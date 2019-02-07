using System;
using System.IO;

namespace CSharp.Parts.Part15_00_Labs
{
    class Part40_ExceptionHandlingRecipes
    {
        public static void Part40_Lab()
        {
            Console.WriteLine("\nException Handling in C#\n===================");

            StreamReader streamReader = new StreamReader(@"E:\LocalOnly\Data\Data.txt");  
            Console.WriteLine(streamReader.ReadToEnd());                                  
            streamReader.Close();                                                        
        }

        public static void Part40_A_Lab()
        {
            Console.WriteLine("\nException Handling in C#\n===================");

            try
            {
                StreamReader streamReader = new StreamReader(@"E:\LocalOnly\Data\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }           
        }

        public static void Part40_B_Lab()
        {
            Console.WriteLine("\nFile Not Found Exception Handling in C#\n===================");

            try
            {
                StreamReader streamReader = new StreamReader(@"E:\LocalOnly\Data\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exist", ex.FileName);
                
            }
        }

        public static void Part40_C_Lab()
        {
            Console.WriteLine("\nDirectory Exception in C#\n===================");

            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"E:\LocalOnly\Data123\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch (FileNotFoundException ex)   
            {
                Console.WriteLine("Please check if the file {0} exist", ex.FileName);

            }
            catch (Exception ex)              
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)    
                {
                    streamReader.Close();
                }                
                Console.WriteLine("Finally Block");
            }
        }



    }
}
