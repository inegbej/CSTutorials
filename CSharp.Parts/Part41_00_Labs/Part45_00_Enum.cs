/* Over time the code becomes less readable as we are using numbers for Gender instead of enum*/
using System;

namespace CSharp.Parts.Part41_00_Labs
{
    // 0 - Unknown
    // 1 - Male
    // 2 - Femaile
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }


    public class Part45_00_Enum
    {
        public static void Enum_Lab()
        {
            Console.WriteLine($"Enums - Why Enums");

            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };

            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name = {customer.Name} && Gender = {GetGender(customer.Gender)}");
            }
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
