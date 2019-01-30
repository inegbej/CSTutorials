/* NOTE: No Delegate was used in this sample*/
/*This class contains properties and method. The method called promote employee will take in a list of employees and then based on some logic print the name of the employee Eligible for promotion e.g if emp experience is more than 5 year promote the employee. */
/* NOTE: This class is not resuasable */

using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{
    class Employee_Part37
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // Method
        public static void PromoteEmployee(List<Employee_Part37> employeeList)
        {
            Console.WriteLine("\nDelegate Usage\n==============");

            foreach (Employee_Part37 employee in employeeList)
            {
                /* NOTE: This logic is not reusable as it is hardcoded */
                if (employee.Experience >= 5)
                {
                    Console.WriteLine($"{ employee.Name } Promoted");
                }
            }
        }
    }

    // Main_Helper - Client
    class Part37_DelegateUsageRecipes
    {       
        public static void Part37_Lab()
        {
            List<Employee_Part37> empList = new List<Employee_Part37>();   // will contain our datasource

            empList.Add(new Employee_Part37() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee_Part37() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee_Part37() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee_Part37() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee_Part37.PromoteEmployee(empList);
        }

    }

}
