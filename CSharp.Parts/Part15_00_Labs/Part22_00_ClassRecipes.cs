/* Method hiding demo with "new" keyword.*/

using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Employee_Part22
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class PartTimeEmployee_Part22 : Employee_Part22
    {
        public new void PrintFullName()     
        {
            Console.WriteLine($"{FirstName} {LastName} - Contractor");    

            //base.PrintFullName();
        }
    }

    public class FullTimeEmployee_Part22 : Employee_Part22
    {
    }


    class Part22_00_ClassRecipes
    {
        public static void Part22_Lab()
        {
            Console.WriteLine($"\nMethod Hiding in C#\n==========");

            FullTimeEmployee_Part22 FTE = new FullTimeEmployee_Part22();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";            
            FTE.PrintFullName();

            PartTimeEmployee_Part22 PTE = new PartTimeEmployee_Part22();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();


            Employee_Part22 PTE1 = new PartTimeEmployee_Part22();  
            PTE1.FirstName = "PartTime";
            PTE1.LastName = "Employee";
            PTE1.PrintFullName();


        }
    }
}
