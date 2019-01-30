using System;

namespace CSharp.Parts
{
    public class Part1_IntroductionNavigation : MainMenu
    {
        public static void Part1_Introction_MainHelper()
        {
            Part1_IntroductionNavigation run = new Part1_IntroductionNavigation();
            run.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nIntro to c#\n==============");

            Console.WriteLine("1 - Lab 1");
            Console.WriteLine("2 - Lab 2");
            Console.WriteLine("3 - Lab 3");
            Console.WriteLine("4 - Lab 4");
            Console.WriteLine("5 - Lab 5");
            Console.WriteLine("6 - Lab 6");
            Console.WriteLine("7 - Lab 7");
            Console.WriteLine("8 - Lab 8");
            Console.WriteLine("9 - Lab 9");
            Console.WriteLine("A - Lab 10");
            Console.WriteLine("B - Lab 11");
            Console.WriteLine("C - Lab 11A");
            Console.WriteLine("D - Lab 12");
            Console.WriteLine("E - Lab 13");
            Console.WriteLine("F - Lab 14");
            Console.WriteLine("G - Lab 14a");
            Console.WriteLine("H - Lab 15");
            Console.WriteLine("I - Lab 15a");
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
                    Part1_Introduction_Labs.Part1_Intro_Lab();
                    break;
                case "2":
                    Part1_Introduction_Labs.Part2_Intro_Lab();
                    break;
                case "3":
                    Part1_Introduction_Labs.Part3_Intro_Lab();
                    break;
                case "4":
                    Part1_Introduction_Labs.Part4_Intro_Lab();
                    break;
                case "5":
                    Part1_Introduction_Labs.Part5_Intro_Lab();
                    break;
                case "6":
                    Part1_Introduction_Labs.Part6_Intro_Lab();
                    break;
                case "7":
                    Part1_Introduction_Labs.Part7_Intro_Lab();
                    break;
                case "8":
                    Part1_Introduction_Labs.Part8_Intro_Lab();
                    break;
                case "9":
                    Part1_Introduction_Labs.Part9_Intro_Lab();
                    break;
                case "A":                
                    Part1_Introduction_Labs.Part10_Intro_Lab();
                    break;
                case "B":
                    Part1_Introduction_Labs.Part11_Intro_Lab();
                    break;
                case "C":
                    Part1_Introduction_Labs.Part11_A_Intro_Lab();
                    break;
                case "D":
                    Part1_Introduction_Labs.Part12_Intro_Lab();
                    break;
                case "E":
                    Part1_Introduction_Labs.Part13_Intro_Lab();
                    break;
                case "F":
                    Part1_Introduction_Labs.Part14_Intro_Lab();
                    break;
                case "G":
                    Part1_Introduction_Labs.Part14_A_Intro_Lab();
                    break;
                case "H":
                    Part1_Introduction_Labs.Part15_Intro_Lab();
                    break;
                case "I":
                    Part1_Introduction_Labs.Part15_A_Intro_Lab();
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
