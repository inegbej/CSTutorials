using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Employee
    {
        // 
        public string FirstName;              
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}.");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    public class A : PartTimeEmployee
    {
    }


    class Part21_00_ClassRecipes
    {
        public static void Part21_Lab()
        {
            Console.WriteLine($"\nInheritance in C#\n==========");

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Pragim";
            FTE.LastName = "Tech";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part";
            PTE.LastName = "Time";
            PTE.PrintFullName();

            // This is a multilevel class inheritance 
            A a1 = new A();
            a1.FirstName = "AA";
            a1.LastName = "BB";
            a1.HourlyRate = 30000;
            a1.PrintFullName();

        }
    }
}
