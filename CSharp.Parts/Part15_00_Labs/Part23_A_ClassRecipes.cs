using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Employee_Part23_A
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} - {LastName}");
        }
    }

    public class PartTimeEmployee_Part23_A : Employee_Part23_A
    {       
    }

    public class FullTimeEmployee_Part23_A : Employee_Part23_A
    {        
    }

    public class TemporaryEmployee_Part23_A : Employee_Part23_A
    {        
    }


    public class Part23_A_ClassRecipes
    {
        public static void Part23_A_Lab()
        {
            Console.WriteLine($"\nPolymorphism in C#\n==========");

            Employee_Part23_A[] employees = new Employee_Part23_A[4];   

            employees[0] = new Employee_Part23_A();                   
            employees[1] = new PartTimeEmployee_Part23_A();          
            employees[2] = new FullTimeEmployee_Part23_A();
            employees[3] = new TemporaryEmployee_Part23_A();

            foreach (Employee_Part23_A e in employees)
            {
                e.PrintFullName();
            }

        }
    }
}
