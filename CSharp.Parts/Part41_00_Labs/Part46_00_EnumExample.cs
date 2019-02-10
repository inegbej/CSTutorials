using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer46
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }


    public class Part46_00_EnumExample
    {
        public static void Enum_Lab46()
        {
            Console.WriteLine($"Enum - Example");

            Customer46[] customers = new Customer46[3];

            customers[0] = new Customer46
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer46
            {
                Name = "Mary",
                Gender = Gender.Female
            };

            customers[2] = new Customer46
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach (Customer46 customer in customers)
            {
                Console.WriteLine($"Name = {customer.Name} && Gender = {GetGender(customer.Gender)}");
            }
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
