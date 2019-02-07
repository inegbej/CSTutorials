using System;

namespace CSharp.Parts.Part15_00_Labs
{
    class Circle
    {
        public static float _PI;   
        int _Radius;

        static Circle()      
        {
            Console.WriteLine($"Static ctor called be/4 instance ctor");
            Circle._PI = 3.141F;
        }

        public Circle(int Radius)
        {
            Console.WriteLine($"Instance ctor called");
            this._Radius = Radius;
        }

        public float CalculateArea()   
        {
            return Circle._PI * this._Radius * this._Radius;
        }

        public static void Print()    
        {
        }

    }

    public class Part20_00_ClassRecipes
    {
        public static void Part20_Lab()
        {
            Console.WriteLine($"\nStatic and instance class members\n========================");

            Circle C1 = new Circle(5);
            float Area = C1.CalculateArea();
            Console.WriteLine($"Area = {Area}.");

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine($"Area2 = {Area2}.");
                        
            Circle.Print();
            //
            Console.WriteLine(Circle._PI);

        }
    }
}
