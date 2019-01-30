using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public abstract class customer_Part33
    {
        int id;   // 1) can have field, 2) access modifier, 3) can inherit from another abstract class or from an interface, 4) can inherit from multiple interface and can inherit from only one class

        public void Print()
        {
            Console.WriteLine("Print");
        }
    }

    public interface Icustomer_Part33
    {
        // int id;     // 1) an interface cannot have fields, 2) cannot have access midifier
                       // 3) an interface can inherit from another interface but not from an abstract class
        void Print();
    }


    class Part33_AbstractInterfaceRecipes
    {
        public static void Part33_Lab()
        {
            Console.WriteLine($"\nDifferences between Abstract class & Interface \n========================");                                   
        }
    }
}












