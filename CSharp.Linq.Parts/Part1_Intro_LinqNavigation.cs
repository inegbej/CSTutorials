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

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nIntro to Linq Aggregate\n==============");

            Console.WriteLine("1 - Find smallest number without Linq");
            Console.WriteLine("2 - Find smallest number with linq");
            Console.WriteLine("3 - Find smallest even number without linq");
            Console.WriteLine("4 - Find smallest even number with linq");
            Console.WriteLine("5 - Find largest number without Linq");
            Console.WriteLine("6 - Find largest number with Linq");
            Console.WriteLine("7 - Find largest even number without Linq");
            Console.WriteLine("8 - Find largest even number with Linq");
            Console.WriteLine("9 - Find Sum of number without Linq");
            Console.WriteLine("10 - Find Sum of number with Linq");
            Console.WriteLine("11 - Find Sum of even number without Linq");
            Console.WriteLine("12 - Find Sum of even number with Linq");
            Console.WriteLine("13 - Find count of number without Linq");
            Console.WriteLine("14 - Find count of number with Linq");
            Console.WriteLine("15 - Find count of even number without Linq");
            Console.WriteLine("16 - Find count of even number with Linq");
            Console.WriteLine("17 - Find avg of number without Linq");
            Console.WriteLine("18 - Find avg of number with Linq");
            Console.WriteLine("19 - Find avg of even number without Linq");
            Console.WriteLine("20 - Find avg of even number with Linq");
            Console.WriteLine("21 - Find shortest country name without Linq");
            Console.WriteLine("22 - Find shortest country name with Linq");
            Console.WriteLine("23 - Find longest country name without Linq");
            Console.WriteLine("24 - Find longest country name with Linq");
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
            switch (myChoice)
            {
                case "1":
                    Part1_Linq_Labs.SmallestNumberWithoutLinq_Lab();
                    break;
                case "2":
                    Part1_Linq_Labs.SmallestNumberWithLinq_Lab2();
                    break;
                case "3":
                    Part1_Linq_Labs.SmallestEvenNumberWithoutLinq_Lab3();
                    break;
                case "4":
                    Part1_Linq_Labs.SmallestEvenNumberWithLinq_Lab4();
                    break;               
                case "5":
                    Part1_Linq_Labs.LargestNumberWithoutLinq_Lab5();
                    break;
                case "6":
                    Part1_Linq_Labs.LargestNumberWithLinq_Lab6();
                    break;
                case "7":
                    Part1_Linq_Labs.LargestEvenNumberWithoutLinq_Lab7();
                    break;
                case "8":
                    Part1_Linq_Labs.LargestEvenNumberWithLinq_Lab8();
                    break;
                case "9":
                    Part1_Linq_Labs.SumOfNumberWithoutLinq_Lab9();
                    break;
                case "10":
                    Part1_Linq_Labs.SumOfNumberWithLinq_Lab10();
                    break;
                case "11":
                    Part1_Linq_Labs.SumOfEvenNumberWithoutLinq_Lab11();
                    break;
                case "12":
                    Part1_Linq_Labs.SumOfEvenNumberWithLinq_Lab12();
                    break;
                case "13":
                    Part1_Linq_Labs.CountOfNumberWithoutLinq_Lab13();
                    break;
                case "14":
                    Part1_Linq_Labs.CountOfNumberWithLinq_Lab14();
                    break;
                case "15":
                    Part1_Linq_Labs.CountOfEvenNumberWithoutLinq_Lab15();
                    break;
                case "16":
                    Part1_Linq_Labs.CountOfEvenNumberWithLinq_Lab16();
                    break;
                case "17":
                    Part1_Linq_Labs.AvgOfNumberWithoutLinq_Lab17();
                    break;
                case "18":
                    Part1_Linq_Labs.AvgOfNumberWithLinq_Lab18();
                    break;
                case "19":
                    Part1_Linq_Labs.AvgOfEvenNumberWithoutLinq_Lab19();
                    break;
                case "20":
                    Part1_Linq_Labs.AvgOfEvenNumberWithLinq_Lab20();
                    break;
                case "21":
                    Part1_Linq_Labs.ShortCountryNameAndCharacterWithoutLinq_Lab21();
                    break;
                case "22":
                    Part1_Linq_Labs.ShortCountryNameAndCharacterWithLinq_Lab22();
                    break;
                case "23":
                    Part1_Linq_Labs.LongestCountryNameWithoutLinq_Lab23();
                    break;
                case "24":
                    Part1_Linq_Labs.LongestCountryNameWithLinq_Lab24();
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
