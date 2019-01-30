using System;

namespace CSharp.Parts.Part15_00_Labs
{
    // State and Behaviour of Class Customer
    public class Customer
    {
        // field - state
        string _firstName;
        string _lastName;

        // ctor: I want to be able to create a contructor without passing it a value
        public Customer() : this("No FirstName Provided", "No LastName Provided")   // calls the ctor below using the 'this' keyword
        {
        }

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        // Behaviour
        // method: Print the full name of our customer
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
