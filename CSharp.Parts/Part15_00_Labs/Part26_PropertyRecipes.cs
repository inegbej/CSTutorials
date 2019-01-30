using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark = 35;
    }

    class Part26_PropertyRecipes
    {
        public static void Part26_Lab()
        {
            Console.WriteLine($"\nUsing public fields instead of Properties in C#\n==============");

            // This business rule has been violated because the fields are marked as public access modifiers
            Student C1 = new Student();
            C1.ID = -101;
            C1.Name = null;
            C1.PassMark = 0;

            Console.WriteLine($"ID = {C1.ID} && Name = {C1.Name} && PassMark = {C1.PassMark }");
        }
    }
}
