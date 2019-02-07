
using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine($"ParentClass ctor called");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine($"{Message}");
        }
    }

    public class ChildClass : ParentClass 
    {
        public ChildClass() : base("Specifying which ctor get called first. Derived class controlling Parent class.")
        {
            Console.WriteLine($"ChildClass ctor called");
        }
    }

    class Part21_A_ClassRecipes
    {
        public static void Part21_A_Lab()
        {
            Console.WriteLine($"\nBase class ctor be/4 Child class ctor\n==========");

            ChildClass CC = new ChildClass();
           
        }
    }
}
