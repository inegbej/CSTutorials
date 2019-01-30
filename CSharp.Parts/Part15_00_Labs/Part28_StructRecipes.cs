using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public struct Customer28
    {
        // fields
        private int _id;
        private string _name;

        // ctor
        public Customer28(int Id, string name)
        {
            this._id = Id;
            this._name = name;
        }

        // properties
        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        // Methods
        public void PrintDetails()
        {
            Console.WriteLine($"Id = { this._id } && Name = { this._name }");
        }

    }

    class Part28_StructRecipes
    {
        public static void Part28_Lab()
        {
            Console.WriteLine($"\nStruct in c#\n==============");

            // create and initialize customer using a constructor - a one liner
            Customer28 C1 = new Customer28(101, "Mark");
            C1.PrintDetails();

            // create and initialize customer using property - in multiple line
            Customer28 C2 = new Customer28();
            C2.Id = 102;
            C2.Name = "John";
            C2.PrintDetails();

            // create and initialize customer using object initializers / short hand notation syntax demos - c# 3.0
            Customer28 C3 = new Customer28
            {
                Id = 103,
                Name = "Rob"
            };
            C3.PrintDetails();           
        }
    }
}
