using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Linq.Parts.Part2_Linq_Intro
{
    public class Part2_IntroNav : MainMenu
    {
        public static void Part2_MainHelper()
        {
            Part2_IntroNav run = new Part2_IntroNav();
            run.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nIntro to Linq\n==============");

            Console.WriteLine("1 - Extension method");
            Console.WriteLine("2 - Linq extension method");
            Console.WriteLine("3 - Linq extension method 2");
            Console.WriteLine("Q - Quit");

            Console.WriteLine("Choose one ( q to quit ): ");

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
                    ExtensionMethodLab.Extension_Lab();
                    break;
                case "2":
                    ExtensionMethodLab.Extension_Lab2();
                    break;
                case "3":
                    ExtensionMethodLab.Extension_Lab3();
                    break;
                case "Q":
                    Console.WriteLine("Bye...");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }
        }
    }
}
