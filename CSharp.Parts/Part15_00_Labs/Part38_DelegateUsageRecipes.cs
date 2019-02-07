
using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{
    delegate bool IsPromotable(Employee_Part38 empl);    // this delegate will return true or false for the passed in employee

    class Employee_Part38
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee_Part38> employeeList, IsPromotable IsEligibleToPromote)  // passed in a list and a delegate function as a parameter
        {
            foreach (Employee_Part38 employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine($"{ employee.Name } Promoted");
                }
            }
        }
    }

    class Part38_DelegateUsageRecipes
    {        
        public static void Part38_Lab()
        {
            Console.WriteLine("\nDelegate Usage Continued\n=============="); 

            List<Employee_Part38> employees = GetSampleEmployee();

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee_Part38.PromoteEmployee(employees, isPromotable);       
        }

        public static List<Employee_Part38> GetSampleEmployee()
        {
            List<Employee_Part38> empList = new List<Employee_Part38>();  

            empList.Add(new Employee_Part38() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee_Part38() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee_Part38() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee_Part38() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            return empList;
        }

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
