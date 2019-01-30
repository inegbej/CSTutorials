using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Part19_00_ClassNavigation : MainMenu
    {
        public static void Part19_00_MainHelper()
        {
            Part19_00_ClassNavigation run = new Part19_00_ClassNavigation();
            run.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nClass MainMenu\n===============");

            Console.WriteLine("1 - Lab19");
            Console.WriteLine("2 - Lab20");
            Console.WriteLine("3 - Lab21");
            Console.WriteLine("4 - Lab21A");
            Console.WriteLine("5 - Lab22");
            Console.WriteLine("6 - Lab23");
            Console.WriteLine("6A - Lab23");
            Console.WriteLine("7 - Lab24");
            Console.WriteLine("8 - Lab24A");
            Console.WriteLine("9 - Lab25");
            Console.WriteLine("10 - Lab26");
            Console.WriteLine("11 - Lab26A");
            Console.WriteLine("12 - Lab27");
            Console.WriteLine("13 - Lab28");
            Console.WriteLine("14 - Lab29");
            Console.WriteLine("15 - Lab29A");
            Console.WriteLine("16 - Lab29B");
            Console.WriteLine("17 - Lab30");
            Console.WriteLine("18 - Lab30A");
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
            switch(myChoice.ToUpper())
            {
                case "1":
                    Part19_00_ClassRecipes.Part19_Lab();
                    break;
                case "2":
                    Part20_00_ClassRecipes.Part20_Lab();
                    break;
                case "3":
                    Part21_00_ClassRecipes.Part21_Lab();
                    break;
                case "4":
                    Part21_A_ClassRecipes.Part21_A_Lab();
                    break;
                case "5":
                    Part22_00_ClassRecipes.Part22_Lab();
                    break;
                case "6":
                    Part23_00_ClassRecipes.Part23_Lab();
                    break;
                case "6A":
                    Part23_A_ClassRecipes.Part23_A_Lab();
                    break;
                case "7":
                    Part24_00_ClassRecipes.Part24_Lab();
                    break;
                case "8":
                    Part24_A_ClassRecipes.Part24_A_Lab();
                    break;
                case "9":
                    Part25_ClassRecipes.Part25_Lab();
                    break;
                case "10":
                    Part26_PropertyRecipes.Part26_Lab();
                    break;
                case "11":
                    Part26_A_PropertyRecipes.Part26_A_Lab();
                    break;
                case "12":
                    Part27_PropertyRecipes.Part27_Lab();
                    break;
                case "13":
                    Part28_StructRecipes.Part28_Lab();
                    break;
                case "14":
                    Part29_StructRecipes.Part29_Lab();
                    break;
                case "15":
                    Part29_StructRecipes.Part29_A_Lab();
                    break;
                case "16":
                    Part29_StructRecipes.Part29_B_Lab();
                    break;
                case "17":
                    Part30_ClassRecipes.Part30_Lab();
                    break;
                case "18":
                    Part30_A_ClassRecipes.Part30_A_Lab();
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
