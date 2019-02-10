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
            Console.WriteLine("4 - Exception abuse solved");
            Console.WriteLine("5 - Why use Enum");
            Console.WriteLine("6 - Enum Example");
            Console.WriteLine("7 - Enum Sample2");
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
                case "4":
                    Part44_00_ExceptionHandlingSolved.ExceptionAbuseSolved();
                    break;
                case "5":
                    Part45_00_Enum.Enum_Lab();
                    break;
                case "6":
                    Part46_00_EnumExample.Enum_Lab46();
                    break;
                case "7":
                    Part47_00_EnumSampletwo.Enum_Lab47();
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
