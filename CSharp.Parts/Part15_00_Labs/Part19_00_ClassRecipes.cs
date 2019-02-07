using System;

namespace CSharp.Parts.Part15_00_Labs
{    
    public class Customer
    {
        // field - state
        string _firstName;
        string _lastName;
        
        public Customer() : this("No FirstName Provided", "No LastName Provided")   
        {
        }

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name = {this._firstName} - {this._lastName}");
        }
    }

    public class Part19_00_ClassRecipes
    {
        public static void Part19_Lab()
        {
            Console.WriteLine($"\nIntroduction to classes\n=======+=======");

            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("Pragim", "Technologies");
            C2.PrintFullName();
        }
    }
}
