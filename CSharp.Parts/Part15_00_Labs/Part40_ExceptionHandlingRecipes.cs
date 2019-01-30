/*Scenario: Trying to read from a file that does not exist, throws FileNotFountException. 
 * Scenario: Read the content of a text file and display in a console window. The file is in my c:\localonly\Data.txt with content " Welcome to online c# training from Pragim Technologies "
 */
using System;
using System.IO;

namespace CSharp.Parts.Part15_00_Labs
{
    // Main_Helper - Client
    class Part40_ExceptionHandlingRecipes
    {
        //  Read the content of a text file and display in a console window. Without handling exception
        public static void Part40_Lab()
        {
            Console.WriteLine("\nException Handling in C#\n===================");

            StreamReader streamReader = new StreamReader(@"E:\LocalOnly\Data\Data.txt");  // location of a file
            Console.WriteLine(streamReader.ReadToEnd());                                  // read content of a file
            streamReader.Close();                                                         // free up resources
        }

        // Output Exceptions
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

        // Handling Exceptions
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
                // Log the details to the DB
                Console.WriteLine("Please check if the file {0} exist", ex.FileName);
                
            }
        }

        // Handling Exceptions: The folder in which the file exist has changed
        public static void Part40_C_Lab()
        {
            Console.WriteLine("\nDirectory Exception in C#\n===================");

            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"E:\LocalOnly\Data123\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch (FileNotFoundException ex)   // will only catch filenotfound exception
            {
                // Log the details to the DB
                Console.WriteLine("Please check if the file {0} exist", ex.FileName);

            }
            catch (Exception ex)              // will catch any other exception including Directory not found exception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)     // Guarantee that resources used get released
                {
                    streamReader.Close();
                }                
                Console.WriteLine("Finally Block");
            }
        }



    }
}
