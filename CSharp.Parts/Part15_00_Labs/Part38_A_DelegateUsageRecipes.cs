
using System;
using System.Collections.Generic;

namespace CSharp.Parts.Part15_00_Labs
{
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
