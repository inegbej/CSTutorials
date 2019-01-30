using System;

namespace CSharp.Linq.Parts
{
    public class Part1_Intro_LinqNavigation : MainMenu
    {
        public static void Part1_Linq_MainHelper()
        {
            Part1_Intro_LinqNavigation run = new Part1_Intro_LinqNavigation();
            run.SetMenu();
        }

        public override char GetMenu()
        {
            char myChoice;

            Console.WriteLine("\nIntro to Linq\n==============");

            Console.WriteLine("1 - Lab 1");
            Console.WriteLine("2 - Lab 2");
            Console.WriteLine("3 - Lab 3");
            Console.WriteLine("4 - Lab 4");
            Console.WriteLine("5 - Lab 5");           
            Console.WriteLine("Q - Quit");

            Console.WriteLine("Choose one ( q to quit ): ");

            do
            {
                myChoice = (char)Console.Read();

            } while (myChoice == '\n' | myChoice == '\r');

            return myChoice;
        }

        public override void MakeDecision(char myChoice)
        {
            switch (myChoice)
            {
                case '1':
                    Part1_Linq_Labs.Part1Linq_Lab();
                    break;
                case '2':
                    Part1_Linq_Labs.Part1Linq_Lab2();
                    break;
                case '3':
                    Part1_Linq_Labs.Part1Linq_Lab3();
                    break;
                case '4':
                    Part1_Linq_Labs.Part1Linq_Lab4();
                    break;               
                case 'A':
                case 'a':
                    break;
                case 'Q':
                case 'q':
                    Console.WriteLine("Bye...");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }
        }
    }
}
