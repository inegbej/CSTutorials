/* Ploymorphism in c# */

using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Employee_Part23
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"{FirstName} - {LastName}");
        }
    }


    public class PartTimeEmployee_Part23 : Employee_Part23
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} - {LastName} - Part Time");
        }
    }

    public class FullTimeEmployee_Part23 : Employee_Part23
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} - {LastName} - Full Time");
        }
    }

    public class TemporaryEmployee_Part23 : Employee_Part23
    {
        //public override void PrintFullName()
        //{
        //    Console.WriteLine($"{FirstName} - {LastName} - Temporary Time");
        //}
    }


    class Part23_00_ClassRecipes
    {
        public static void Part23_Lab()
        {
            Console.WriteLine($"\nPolymorphism in C#\n==========");

            Employee_Part23[] employees = new Employee_Part23[4];   // create an array of base class

            employees[0] = new Employee_Part23();                   // initialise the base class
            employees[1] = new PartTimeEmployee_Part23();           // initialise derived classes into base class
            employees[2] = new FullTimeEmployee_Part23();
            employees[3] = new TemporaryEmployee_Part23();

            foreach(Employee_Part23 e in employees)
            {
                e.PrintFullName();
            }

        }
    }
}
