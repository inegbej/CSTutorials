using System;

namespace CSharp.Parts
{
    public class Part1_Introduction_Labs
    {
        public static void Part1_Intro_Lab()
        {
            Console.WriteLine("\nWelcome to c# Training\n=============");
        }

        public static void Part2_Intro_Lab()
        {
            Console.WriteLine("\nReading and Writing to Console\n=============");

            Console.WriteLine("Please enter your firstname");
            //string UserName = Console.ReadLine();
            string FirstName = "Joseph";

            Console.WriteLine("Please enter your lastname");
            //string UserName = Console.ReadLine();
            string LastName = "Inegbe";

            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        }

        public static void Part3_Intro_Lab()
        {
            Console.WriteLine("\nBuilt in data types in c#\n=============");

            bool b = true;
            int x = 0;
            double d = 123.22242433;   // The doble keyword signifies a simple type that stores 64-bit floating point value
            decimal de = 300.0m;       // The decimal keyword has more precision and a smaller range. This makes it appropiate for financial and monetory calculation.

            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            Console.WriteLine(d);
        }

        public static void Part4_Intro_Lab()
        {
            Console.WriteLine("\n String - Built in data types in c#\n=================");

            string Name = "Joseph";     // string demo

            string Name1 = "\"Joseph";      // escape sequences demo
            string Name2 = "\"Joseph\"";    // enclosed in double quotes

            // Non printable character eg \n, \r

            // New line characters
            string newLine = "One\nTwo\nThree";
            string newLine1 = "C:\\Pragim\\DotNet\\Training\\Csharp";

            // verbatim literal
            string newLine2 = @"C:\\Pragim\\DotNet\\Training\\Csharp";
            string newLine3 = @"C:\Pragim\DotNet\Training\Csharp";


            Console.WriteLine("String: " + Name);
            Console.WriteLine("Escape Sequence: " + Name1);
            Console.WriteLine("Escape Sequence: " + Name2);
            Console.WriteLine("New Line:\n=====\n" + newLine);
            Console.WriteLine("New Line: " + newLine1);
            Console.WriteLine("Verbatim literal: " + newLine2);
            Console.WriteLine("Verbatim literal: " + newLine3);
        }

        public static void Part5_Intro_Lab()
        {
            Console.WriteLine("\n Common operators in c#\n=================");

            int i = 10;     // assignment operator
            bool b = true;  // boolean

            int Numerator = 10;     // division and modular operator
            int Denominator = 2;
            int Result = Numerator / Denominator;         // division (/)
            int Result1 = Numerator % Denominator;        // Modular/reminder (%)

            Console.WriteLine("Division: " + Result);
            Console.WriteLine("Modulus: " + Result1);

            int Number = 10;         // assignment operator
            if (Number == 10) { }    // Comparison operator
            if (Number != 10) { }

            int Number1 = 10;        // Conditional operators
            int AnotherNumber = 20;
            if (Number1 == 10 && AnotherNumber == 20)   // Both condition must be true to print "Hello"
            {
                Console.WriteLine("Hello");
            }
            if (Number1 == 10 || AnotherNumber == 20)   // one of the condition must be true to print "Hello2"
            {
                Console.WriteLine("Hello2");
            }

            int Number2 = 10;                          // Ternary Operator
            bool IsNumber10 = Number2 == 10 ? true : false;

            //bool IsNumber10;     // too many lines of code
            //if (Number2 == 10)
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}
            Console.WriteLine("Number == 10 is {0}", IsNumber10);
        }

        public static void Part6_Intro_Lab()
        {
            Console.WriteLine("\n Nullable Types in c#\n=================");

            string Name = null;  // by default nullable
            //int j = null;      // by default not nullable
            int? i = null;       // nullable value type

            bool? AreYouMajor = null;     // can be true, false, Null
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }

            // Null Coalescing Operator
            Console.WriteLine("\n Null Coalescing Operator\n=================");

            int? TicketOnSale = null;
            int AvailableTickets = TicketOnSale ?? 0;   // if TicketOnSale is null use the default of 0 otherwise use TicketOnSale value

            //int AvailableTickets;
            //if(TicketOnSale == null)  // too many codes
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketOnSale;
            //}
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

        }

        public static void Part7_Intro_Lab()
        {
            Console.WriteLine("\n Data Types Conversions\n=================");

            int i = 100;           // Implicit conversion - NO loss of data
            float f = i;
            Console.WriteLine(f);

            float fi = 123.45F;    //  Explicit conversion - loss of data 
            //int ix = (int)fi;
            int ix = Convert.ToInt32(fi);
            Console.WriteLine(ix);

            //string strNumber = "100TG";
            string strNumber = "100";
            //int iy = int.Parse(strNumber);  // Using int.Parse on "100GT" will throw format exception BUT "100" will be ok
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);   // TryParse will try to convert "100TG" to interger and save it into Result variable BUT if it cannot, Result variable will remain 0.
            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        public static void Part8_Intro_Lab()
        {
            Console.WriteLine("\n Arrays\n========");

            int[] EvenNumber = new int[3];
            EvenNumber[0] = 0;
            EvenNumber[1] = 2;
            EvenNumber[2] = 4;
            //EvenNumber[6] = 6;   // index out of range exception

            Console.WriteLine(EvenNumber[1]);

        }

        public static void Part9_Intro_Lab()
        {
            Console.WriteLine("\n Comment in c#\n========");

            //Console.WriteLine("Hello");         // Ctrl+K, Ctrl+C and Ctrl+K, Ctrl+U
            /*Console.WriteLine("Hello");*/

            SampleClass sc = new SampleClass();   // Hover over SampleClass and notice the documentation
        }

        public static void Part10_Intro_Lab()
        {
            Console.WriteLine("\n If statement in c#\n========");

            Console.WriteLine("Please enter a number");

            //int UserNumber = int.Parse(Console.ReadLine());
            int UserNumber = 10;
            //int UserNumber = 1;

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("{0} is invalid. Please enter 1, 2 or 3", UserNumber);
            }

            // 
            //  && more efficient than &.
            //  || more efficient than |.

        }

        public static void Part11_Intro_Lab()
        {
            Console.WriteLine("\n Switch statement in c#\n========");

            Console.WriteLine("Please enter a number");

            //int UserNumber = int.Parse(Console.ReadLine());
            int UserNumber = 10;
            //int UserNumber = 1;

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;
            }

        }

        public static void Part11_A_Intro_Lab()
        {
            Console.WriteLine("\nMultiple Switch statement in c#\n========");

            Console.WriteLine("Please enter a number");

            //int UserNumber = int.Parse(Console.ReadLine());
            int UserNumber = 30;
            //int UserNumber = 1;

            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;
            }
        }

        // Scenario: Buy coffee and present a bill
        public static void Part12_Intro_Lab()
        {
            Console.WriteLine("\nSwitch statement - Coffee Program\n=============");

            int TotalCoffeeCost = 0;     // To store coffee price initialized to zero

            Start:                       // This is a label
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");

            //int UserChoice = int.Parse(Console.ReadLine());
            int UserChoice = 2;

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;      // small coffee cost $1
                    break;
                case 2:
                    TotalCoffeeCost += 2;      // Medium coffee cost $2
                    break;
                case 3:
                    TotalCoffeeCost += 3;      // Large coffee cost $3
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    break;
            }

            Decide:                        // This is a label
            Console.WriteLine("Do you wamt to buy another coffee - Yes or No?");
            //string UserDecision = Console.ReadLine();
            string UserDecision = "N";

            switch (UserDecision.ToLower())
            {
                case "y":
                    goto Start;           // try and avoid using goto                              
                case "n":
                    break;
                default:
                    Console.WriteLine("{0} is invalid Decision", UserDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill amount = {0}", TotalCoffeeCost);

        }


        public static void Part13_Intro_Lab()
        {
            Console.WriteLine("\nWhile Loop in c#\n=============");

            Console.WriteLine("Please enter your target?");

            //int userTarget = int.Parse(Console.ReadLine());
            int userTarget = 12;

            int start = 0;       // number to start printing even number

            while (start <= userTarget)
            {
                Console.Write(start + " ");
                start = start + 2;        // Increment start by 2. without this line of code we will have an indefinite loop
            }

        }

        public static void Part14_Intro_Lab()
        {
            Console.WriteLine("\nDo While Loop in c#\n=============");

            string userChoice = "";

            do
            {
                Console.WriteLine("Please enter your target?");

                //int userTarget = int.Parse(Console.ReadLine());
                int userTarget = 12;

                int start = 0;       // number to start printing even number

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to Continue - Yes or No?");
                    //UserChoice = Console.ReadLine().ToUpper();
                    userChoice = "N";

                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");

        }

        // Scenario: Buy coffee and present a bill - Do While Demo
        public static void Part14_A_Intro_Lab()
        {
            Console.WriteLine("\nDo While Loop - Coffee Program\n=============");

            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;

            do
            {
                int UserChoice = -1;
                do
                {
                    Console.WriteLine("Please select your coffee size: 1 - small, 2 - medium, 3 - Large");
                    //UserChoice = int.Parse(Console.ReadLine());
                    UserChoice = 2;

                    switch (UserChoice)
                    {
                        case 1:
                            TotalCoffeeCost += 1;
                            break;
                        case 2:
                            TotalCoffeeCost += 2;
                            break;
                        case 3:
                            TotalCoffeeCost += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", UserChoice);
                            break;
                    }
                } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    //UserDecision = Console.ReadLine();
                    UserDecision = "N";

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision.ToUpper() != "NO");
        }

        public static void Part15_Intro_Lab()
        {
            Console.WriteLine("\nFor & ForEach Loop\n=============");

            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            Console.WriteLine("\nWhile Demo\n=========");

            int i = 0;  // counter to loop through array
            while(i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            Console.WriteLine("\nFor Loop Demo\n=========");
            for(int j = 0; j < Numbers.Length; j++)      // for loop: loop throgh the length of the array
            {
                Console.WriteLine(Numbers[j]);
            }

            Console.WriteLine("\nForeach Loop Demo\n=========");
            foreach (var num in Numbers)       // foreach loop: loop through item in a collection
            {
                Console.WriteLine(num);
            }

        }

        public static void Part15_A_Intro_Lab()
        {
            Console.WriteLine("\nBreak & Continue\n=============");

            Console.WriteLine("\nLoop Demo\n==========");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBreak Demo\n==========");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }

            Console.WriteLine("\nContinue Demo\n==========");
            // Secenario: i want to print even numbers only until 10 or till 20 but i don't want to increment the counter by 2
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;           // if continue is hit writeline below will be unreachable, the code will go back to for loop and start over again

                Console.WriteLine(i);   // even numbers are printed
            }

            Console.WriteLine("\nPrint Even number till 20\n==========");
            for (int i = 0; i <= 20; i = i+2)
            {
                Console.WriteLine(i);
            }

        }

    }

    // For Part9_Intro_Lab() sample
    /// <summary>
    /// This is a Sample Class and a sample documentation
    /// </summary>
    public class SampleClass
    {

    }

}
