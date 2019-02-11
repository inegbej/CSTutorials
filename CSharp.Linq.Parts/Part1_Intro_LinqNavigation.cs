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

            Console.WriteLine("\nIntro to Linq Aggregate\n==============");

            Console.WriteLine("1 - Find smallest number without Linq");
            Console.WriteLine("2 - Find smallest number with linq");
            Console.WriteLine("3 - Find smallest even number without linq");
            Console.WriteLine("4 - Find smallest even number with linq");
            Console.WriteLine("5 - Find largest number without Linq");
            Console.WriteLine("6 - Find largest number with Linq");
            Console.WriteLine("7 - Find largest even number without Linq");
            Console.WriteLine("8 - Find largest even number with Linq");
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
                    Part1_Linq_Labs.SmallestNumberWithoutLinq_Lab();
                    break;
                case '2':
                    Part1_Linq_Labs.SmallestNumberWithLinq_Lab2();
                    break;
                case '3':
                    Part1_Linq_Labs.SmallestEvenNumberWithoutLinq_Lab3();
                    break;
                case '4':
                    Part1_Linq_Labs.SmallestEvenNumberWithLinq_Lab4();
                    break;               
                case '5':
                    Part1_Linq_Labs.LargestNumberWithoutLinq_Lab5();
                    break;
                case '6':
                    Part1_Linq_Labs.LargestNumberWithLinq_Lab6();
                    break;
                case '7':
                    Part1_Linq_Labs.LargestEvenNumberWithoutLinq_Lab7();
                    break;
                case '8':
                    Part1_Linq_Labs.LargestEvenNumberWithLinq_Lab8();
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
