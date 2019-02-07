using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{
    class Employee_Part37
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee_Part37> employeeList)
        {
            Console.WriteLine("\nDelegate Usage\n==============");

            foreach (Employee_Part37 employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine($"{ employee.Name } Promoted");
                }
            }
        }
    }

    class Part37_DelegateUsageRecipes
    {       
        public static void Part37_Lab()
        {
            List<Employee_Part37> empList = new List<Employee_Part37>();   

            empList.Add(new Employee_Part37() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee_Part37() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee_Part37() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee_Part37() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee_Part37.PromoteEmployee(empList);
        }

    }

}
