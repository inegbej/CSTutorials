using System;

namespace CSharp.Parts.Part15_00_Labs
{
    // State and behaviour of Class Circle
    class Circle
    {
        // fields = state
        //float _PI = 3.141F;       // instance field
        public static float _PI;    // static field
        int _Radius;

        // static ctor: are called only once no matter how many instances you create
        static Circle()      //static ctor are automatically invoked be/4 instance ctor or be/4 the fields are refered to. Used to initialised static fields
        {
            Console.WriteLine($"Static ctor called be/4 instance ctor");
            Circle._PI = 3.141F;
        }

        // instance ctor
        public Circle(int Radius)
        {
            Console.WriteLine($"Instance ctor called");
            this._Radius = Radius;
        }

        // Behaviours
        // Calculate circle area and return the area to the calling method
        public float CalculateArea()   // instance method
        {
            return Circle._PI * this._Radius * this._Radius;
        }

        public static void Print()    // static method
        {
        }

    }

    public class Part20_00_ClassRecipes
    {
        public static void Part20_Lab()
        {
            Console.WriteLine($"\nStatic and instance class members\n========================");

            // instance class demo
            Circle C1 = new Circle(5);
            float Area = C1.CalculateArea();
            Console.WriteLine($"Area = {Area}.");

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine($"Area2 = {Area2}.");

            // static class demo
            Circle.Print();
            //
            Console.WriteLine(Circle._PI);

        }
    }
}
