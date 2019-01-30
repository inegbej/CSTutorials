/*This class contains properties and method. The method called promote employee will take in a list of employees and then based on some logic print the name of the employee Eligible for promotion e.g if emp experience is more than 5 year promote the employee. */
using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{

    // Main_Helper - Client
    class Part38_A_DelegateUsageRecipes
    {
        public static void Part38_A_Lab()
        {
            Console.WriteLine("\nDelegate Usage with Lambda\n=============="); 

            List<Employee_Part38> employees = Part38_DelegateUsageRecipes.GetSampleEmployee();

            Employee_Part38.PromoteEmployee(employees, emp => emp.Experience >= 5);
        }

        
    }
}
