using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public class Part41_00_ClassNavigation : MainMenu
    {
        public static void Part41_00_MainHelper()
        {
            Part41_00_ClassNavigation nav = new Part41_00_ClassNavigation();
            nav.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nPart41... - MainMenu\n===============");

            Console.WriteLine("1 - Inner Exception");
            Console.WriteLine("2 - Custom Exception");
            Console.WriteLine("3 - Exception Abuse");           
            Console.WriteLine("Q - Quit");

            Console.WriteLine("Choose (q to quit): ");

            do
            {
                myChoice = Console.ReadLine();
            } while (myChoice == "\n" || myChoice == "\r");
            return myChoice;

        }

        public override void MakeDecision(string myChoice)
        {
            switch (myChoice.ToUpper())
            {
                case "1":
                    Part41_00_InnerExceptionRecipes.InnerException_Lab();
                    break;
                case "2":
                    Part42_00_CustomExceptions.Part42_Lab();
                    break;
                case "3":
                    Part43_00_ExceptionHandlingAbuse.ExceptionAbuse();
                    break;
                case "Q":
                    Console.WriteLine("Bye...");
                    break;
                default:
                    Console.WriteLine($"{myChoice} is invalid try again");
                    break;
            }
        }
    }
}
