using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class BaseClass_Part24_A
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base class Print Method");
        }
    }


    public class DerivedClass_Part24_A : BaseClass_Part24_A
    {
        public new void Print()
        {
            Console.WriteLine("I am a derived class Print Method");
        }
    }


    class Part24_A_ClassRecipes
    {
        public static void Part24_A_Lab()
        {
            Console.WriteLine($"\nMethod hiding in C#\n========================");

            BaseClass_Part24_A B = new DerivedClass_Part24_A();   // In this scenario the "base" class Print() method is called. Because a base class variable is pointing to a derived class object in memory.
            B.Print();                                            

            DerivedClass_Part24_A D = new DerivedClass_Part24_A(); 
            D.Print();                                            
        }
    }
}
