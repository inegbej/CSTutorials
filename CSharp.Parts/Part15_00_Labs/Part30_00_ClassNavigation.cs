using System;

namespace CSharp.Parts.Part15_00_Labs
{
    class Part30_00_ClassNavigation : MainMenu
    {
        public static void Part30_00_MainHelper()
        {
            Part30_00_ClassNavigation run = new Part30_00_ClassNavigation();
            run.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nClasses MainMenu\n===============");

            Console.WriteLine("1 - Lab31");
            Console.WriteLine("2 - Lab31A");
            Console.WriteLine("3 - Lab31B");
            Console.WriteLine("4 - Lab31C");
            Console.WriteLine("5 - Lab31D");
            Console.WriteLine("6 - Lab32");
            Console.WriteLine("7 - Lab33");
            Console.WriteLine("8 - Lab35");
            Console.WriteLine("9 - Lab36");
            Console.WriteLine("10 - Lab37");
            Console.WriteLine("11 - Lab38");
            Console.WriteLine("12 - Lab38A");
            Console.WriteLine("13 - Lab39");
            Console.WriteLine("14 - Lab39A");
            Console.WriteLine("15 - Lab39B");
            Console.WriteLine("16 - Lab39C");
            Console.WriteLine("17 - Lab39D");
            Console.WriteLine("18 - Lab40");
            Console.WriteLine("19 - Lab40A");
            Console.WriteLine("20 - Lab40B");
            Console.WriteLine("21 - Lab40C");
            Console.WriteLine("22 - Lab40D");
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
                    Part31_InterfaceRecipes.Part31_Lab();
                    break;
                case "2":
                    Part31_InterfaceRecipes.Part31_A_Lab();
                    break;
                case "3":
                    Part31_A_InterfaceRecipes.Part31_A_A_Lab();
                    break;
                case "4":
                    Part31_A_InterfaceRecipes.Part31_A_B_Lab();
                    break;
                case "5":
                    Part31_B_InterfaceRecipes.Part31_B_Lab();
                    break;
                case "6":
                    Part32_AbstractRecipes.Part32_Lab();
                    break;
                case "7":
                    Part33_AbstractInterfaceRecipes.Part33_Lab();
                    break;
                case "8":
                    Part35_MultipleInterfaceInheritanceRecipes.Part35_Lab();
                    break;
                case "9":
                    Part36_DelegateRecipes.Part36_Lab();
                    break;
                case "10":
                    Part37_DelegateUsageRecipes.Part37_Lab();
                    break;
                case "11":
                    Part38_DelegateUsageRecipes.Part38_Lab();
                    break;
                case "12":
                    Part38_A_DelegateUsageRecipes.Part38_A_Lab();
                    break;
                case "13":
                    Part39_MulticastDelegateRecipes.Part39_Lab();
                    break;
                case "14":
                    Part39_A_MulticastDelegateRecipes.Part39_A_Lab();
                    break;
                case "15":
                    Part39_B_MulticastDelegateRecipes.Part39_B_Lab();
                    break;
                case "16":
                    Part39_C_MulticastDelegateRecipes.Part39_C_Lab();
                    break;
                case "17":
                    Part39_D_MulticastDelegateRecipes.Part39_D_Lab();
                    break;
                case "18":
                    Part40_ExceptionHandlingRecipes.Part40_Lab();
                    break;
                case "19":
                    Part40_ExceptionHandlingRecipes.Part40_A_Lab();
                    break;
                case "20":
                    Part40_ExceptionHandlingRecipes.Part40_B_Lab();
                    break;
                case "21":
                    break;
                case "22":
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
