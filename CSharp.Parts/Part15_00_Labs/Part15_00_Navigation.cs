using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Part15_00_Navigation : MainMenu
    {
        public static void Part15_00_MainHelper()
        {
            Part15_00_Navigation run = new Part15_00_Navigation();
            run.SetMenu();
        }

        public override string GetMenu()
        {
            string myChoice;

            Console.WriteLine("\nPart15_00_Labs\n==============");

            Console.WriteLine("1  - Lab 16");
            Console.WriteLine("1a - Lab 16A");
            Console.WriteLine("1b - Lab 16B");
            Console.WriteLine("2 - Lab 17");
            Console.WriteLine("2b - Lab 17B");
            Console.WriteLine("2C - Lab 17C");
            Console.WriteLine("2D - Lab 17D");
            Console.WriteLine("8 - Lab 8");            
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
                    Part15_00_Recipes.Part16_Lab();
                    break;
                case "1A":
                    Part15_00_Recipes.Part16_A_Lab(30);
                    break;
                case "1B":
                    Part15_00_Recipes.Part16_B_Helper_Lab();
                    break;
                case "2":
                    Part15_00_Recipes.Part17_A_Helper_Lab();
                    break;
                case "2B":
                    Part15_00_Recipes.Part17_B_Helper_Lab();
                    break;
                case "2C":
                    Part15_00_Recipes.Part17_C_Helper_Lab();
                    break;
                case "2D":
                    Part15_00_Recipes.Part17_D_Helper_Lab();
                    break;
                case "8":
                    Part15_00_Recipes.Part18_Lab();
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
