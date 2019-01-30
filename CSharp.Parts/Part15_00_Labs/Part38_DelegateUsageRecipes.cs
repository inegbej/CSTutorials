/*This class contains properties and method. The method called promote employee will take in a list of employees and then based on some logic print the name of the employee Eligible for promotion e.g if emp experience is more than 5 year promote the employee. */
/* Delegate can be passed in as a function to a parameter*/
using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{
    // Delegate
    delegate bool IsPromotable(Employee_Part38 empl);    // this delegate will return true or false for the passed in employee

    // 
    class Employee_Part38
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // Method
        public static void PromoteEmployee(List<Employee_Part38> employeeList, IsPromotable IsEligibleToPromote)  // passed in a list and a delegate function as a parameter
        {
            foreach (Employee_Part38 employee in employeeList)
            {
                /* replaced expression with delegate */
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine($"{ employee.Name } Promoted");
                }
            }
        }
    }


    // Main_Helper - Client
    class Part38_DelegateUsageRecipes
    {        
        public static void Part38_Lab()
        {
            Console.WriteLine("\nDelegate Usage Continued\n=============="); 

            // Get Data source
            List<Employee_Part38> employees = GetSampleEmployee();

            // create a Delegate object
            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee_Part38.PromoteEmployee(employees, isPromotable);       // method call: Takes in a list of employees amd a delegate
        }

        // Mock Data Source
        public static List<Employee_Part38> GetSampleEmployee()
        {
            List<Employee_Part38> empList = new List<Employee_Part38>();  // will contain our datasource

            empList.Add(new Employee_Part38() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee_Part38() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee_Part38() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee_Part38() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            return empList;
        }

        // Method to be passed to a delegate
        public static bool Promote(Employee_Part38 emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
